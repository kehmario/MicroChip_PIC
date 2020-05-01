# MicroChip_PIC
 Projects that use the Microchip PIC family

Project was built using CAWARE CCS-C PCH Compiler for 8-bit microcontrollers
Chip used PIC18F4455 PDIP

If using code to implement into other chips, make sure the FUSES and clock settings are correct.

If implementation is done using ADC Clock, remove the variable SRD that stores a value to manipulate the analog sampling rate scheme.

Code will not work with MPLabX unless the compiler/linker has the .crg file from C-AWARE
