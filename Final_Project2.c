#include <18f4455.h>
#FUSES NOWDT, NOPROTECT, NOBROWNOUT ,PUT ,NODEBUG, NOWRT ,NOLVP ,USBDIV,PLL5 ,CPUDIV1
#use delay(clock = 48mhz, crystal = 20mhz)
#use RS232(UART1, BAUD=115200, PARITY=N, BITS=8, STOP=1, TIMEOUT = 500, XMIT = PIN_C6, ERRORS)
#include <lcd.c>
#include "kbd_yz.c"

int1 kflag = 0;
int1 guiReady = 1;
char key;

void sample10();
void stop();
int32 get_time();
void enable_int(void){
      set_tris_D(0x01E); // Set column output, row input
      kbd=0x1E;   // Set all columns low, all rows high
      ext_int_edge(0,L_to_H); // set external interrupt
      clear_interrupt(INT_EXT); // register/output keep old values, need to be cleared
      enable_interrupts(INT_EXT); // these 5 statements may be grouped in a function
}

#INT_TIMER1
void timer1(){

}

#INT_EXT
void keyboard_isr()
{
   key = kbd_getc();
   kflag = 1;
}

#INT_RDA
void serial_isr()
{
   key = getc();
   kflag = 1;
}

      int trigger = 128;
      int32 SRD = 0;
      //int32 time1 = 0;
      int16 reading; 
      int8 read[200];

void main()
{
      if(SRD<0)
      SRD = 0; // ensures no negative
      //Configure ADC controls
      lcd_init();
      kbd_init();
      enable_interrupts(INT_RDA);
      enable_interrupts(Global);
      setup_adc_ports( AN0_ANALOG ); //Use PIN AN0 for analog input
      setup_adc( ADC_CLOCK_DIV_4 | ADC_TAD_MUL_20 );
      SETUP_TIMER_1(T1_INTERNAL | T1_DIV_BY_2); 
      
      
      set_adc_channel( 0 ); //Points A/D channel to AN0
      lcd_putc("\fECE 422");
      lcd_putc("\n\rMario Keh");
   while (TRUE)
   {
      Start: ; 
      enable_int();
      if(key!=0&&kflag==1)
      {
         disable_interrupts(INT_EXT);                                                                                     
         kflag=0;                                                            
         switch(key){                                                           
            case '#': disable_interrupts(INT_EXT); printf(lcd_putc,"\fStopped Sampling"); key = '$';  enable_int(); break;
            case '@': guiReady = 1;set_timer1(0);key = '*'; sample10(); break; 
            case '*': sample10(); break; 
            case 'U': trigger-=10; key = '*'; sample10(); break;
            case 'D': trigger+=10; key = '*'; sample10(); break;
            case '+': trigger+=50; key = '*'; sample10(); break;
            case '-': trigger-=50; key = '*'; sample10(); break;
            case '2': SRD += 10; key = '*'; sample10(); break;
            case '3': SRD -= 10; key = '*'; sample10(); break;
            case 'v': SRD += 100; key = '*'; sample10(); break;
            case '^': SRD -= 100; key = '*'; sample10(); break;
            case '4': printf(lcd_putc,"cleared"); lcd_putc("\f");break;
            case '5': printf("\f");break;
            case 'X': delay_us(10); printf("%lu",SRD); printf("\n"); delay_us(10); key = '*'; sample10(); break;
            //case 'Y': delay_us(10);get_time(); delay_us(10); key = '*'; sample10(); break;
            default :  break;
             }
         enable_int();                                                           
      }  
   }
}
/*
int32 get_time()
   {
   printf("%lu", time1);
   printf("\n");
   }
   */
void sample10()
{
   while(key == '*')
   {
      reading = read_adc();
      while(reading < trigger) 
      {
         reading = read_adc();
         if(reading > trigger)
         {
            
            if(SRD == 0)
            {
               for(int i = 0; i < 200; i++)
               {
                  read[i] = read_adc();
               }
               if(guiReady)
               {
                  guiReady = 0;
                  for(int j = 0; j < 200; j++)
                  {
                     putc(read[j]);
                  }                            }
               printf(lcd_putc,"\f\rOutput1"); 
            }   
            else
            {
               for(int k = 0; k < 200; k++)
               {
                  read[k] = read_adc();
                  delay_us(SRD);
               }
               if(guiReady)
               {
                  guiReady = 0;
                  for(int l = 0; l < 200; l++)
                  {
                     putc(read[l]);
                  }
               }
               printf(lcd_putc,"\f\rOutput");   
            }            }              }    }  
    return;
 }
   




