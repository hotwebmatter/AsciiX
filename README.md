# AsciiX
Third programming exercise for C# class

## Example output

```
Choose an option:
1 = ASCII Art X
2 = Algorithmic X

To exit, press 0 (zero) key.



1
Generating ASCII Art X ...

 __   __
 \ \ / /
  \ V /
   > <
  / . \
 /_/ \_\

Press any key to return to menu.

Choose an option:
1 = ASCII Art X
2 = Algorithmic X

To exit, press 0 (zero) key.

2
Generating Algorithmic X ...
Enter desired height of X:
5
The desired height is 5.
 #   #
  # #
   #
  # #
 #   #
Press any key to return to menu.

Choose an option:
1 = ASCII Art X
2 = Algorithmic X

To exit, press 0 (zero) key.

2
Generating Algorithmic X ...
Enter desired height of X:
15
The desired height is 15.
 #             #
  #           #
   #         #
    #       #
     #     #
      #   #
       # #
        #
       # #
      #   #
     #     #
    #       #
   #         #
  #           #
 #             #
Press any key to return to menu.

Choose an option:
1 = ASCII Art X
2 = Algorithmic X

To exit, press 0 (zero) key.

2
Generating Algorithmic X ...
Enter desired height of X:
55
The desired height is 55.
 #                                                     #
  #                                                   #
   #                                                 #
    #                                               #
     #                                             #
      #                                           #
       #                                         #
        #                                       #
         #                                     #
          #                                   #
           #                                 #
            #                               #
             #                             #
              #                           #
               #                         #
                #                       #
                 #                     #
                  #                   #
                   #                 #
                    #               #
                     #             #
                      #           #
                       #         #
                        #       #
                         #     #
                          #   #
                           # #
                            #
                           # #
                          #   #
                         #     #
                        #       #
                       #         #
                      #           #
                     #             #
                    #               #
                   #                 #
                  #                   #
                 #                     #
                #                       #
               #                         #
              #                           #
             #                             #
            #                               #
           #                                 #
          #                                   #
         #                                     #
        #                                       #
       #                                         #
      #                                           #
     #                                             #
    #                                               #
   #                                                 #
  #                                                   #
 #                                                     #
Press any key to return to menu.

Choose an option:
1 = ASCII Art X
2 = Algorithmic X

To exit, press 0 (zero) key.



0
Exiting...

C:\Program Files\dotnet\dotnet.exe (process 8980) exited with code 0.
To automatically close the console when debugging stops, enable Tools->Options->Debugging->Automatically close the console when debugging stops.
Press any key to close this window . . .
```

# Note

In order to make the Algorithmic X work correctly with even-numbered height input,
use modulo operator (%) to conditionally omit center if height is divisible by two.