using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Animations
{
    public class Logo
    {
        public static void PrintLogo()
        {
            Console.WriteLine(@"
                  ,#############,                                                ,*#################*,                                                                                               
               %######################%                                        /#######################(                                                                                         
              /##########################(                                    .%#########################%                                                              .%#%%%%%%%%.             
             .#############   .*#%#########                                   #############.    ,%#########*                                                            %#########/              
             %###########%          *######(                                 /############/          %######                                                           *##########               
            /############*            /####%  .#########(      /#########*  .%###########%             #####*      ,%%###########\       %%%%%%%%%%#     .%%%%%%%%%%  .%########%.               
           .#############              /###%  %#########/     *#########%   #############.              ####*  .%##,       *########.   ,##########      %#########/  ##########/                
           %###########%               ,###( *##########      %########%.  (############*               ###%  ,%/          %########%   %#########.     /#########(  *#########(                 
          /############*               /##% .%########%.     (#########/  .%###########%                ###*              .#########%  (##########     .#########%   %########%.                 
          #############               *##%  ##########/     *#########%   #############.               ###/    *%%####%%  %#########. .##########      %#########*  (#########/                  
         %############               *###  *##########      %#########,  (############/               ###.  %######%    ,###########  %#########,     *##########  ,##########                   
        (############*             .%#%    %########%.     (#########/  .%###########%              ###,  #########     .#########%  (##########      %########%   %########%.,%##(              
       .#############            (##(     (#########/     ,#########%   #############.           .%#%   ,#########*     %#########. .##########      %#########*  (#########/ ####( ,%%*#/       
       %#############     *#####%        ,##########      %#########,  (############(      ,(%##%.      #########%     ###########  %#########.     ,##########  ,##########  ,## .%##%          
      (##################,               #########%.     (#########/  ,%###########%(/***,             /#########     .#########%  .##########      %########%   %########%.       %###%.        
     .############%%########             %########(   (###########%   #############.                   .########/    ###########,  .#########   *%%##########/  /#########(        .%###/        
     %############   ###########%,       .%#########%.  %#########*  (############*                     .%######%%#% (##########    *#########%,  ,##########  ,#########%       #, .%%*         
    #############,     .%##############%%#*                         ,############%                                                                                                               
   .#############         .%####################################################%.    DDDDDDD     RRRRRRR      AAAAAA     GGGGGGG          RRRRRRRR     AAAAAA     CCCCCCC   EEEEEEE            
   %############              /%################################################*    DDDD  DDD   RRRR  RRR    AAAAAAA   GGGG   ***        RRRR  RRR    AAAAAAA   CCCC   CCC /EEE                
  /############.                   #############################################    DDDD   DDD   RRRRRRR     AAAA AAA  GGGG  gggg        RRRRRRRR     AAAA AAA  CCCC        EEEEEEE             
  #############                         .#%###################################%.   DDDD   DDD   RRR  RRR    AAAAAAAAA  GGGG   GGG       RRRR  RRR    AAAAAAAAA  CCCC   CCC  EEEE                 
 %############                                   ,(###########################*   *DDDDDDDD%   RRRR  RRR   AAAA   AAA  GGGGGGGG        RRRR   RRR   AAAA   AAA   CCCCCCCC  /EEEEEEE   ");
        }

        public static void ThemeSong()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            PrintLogo();
            Console.Beep(600, 125);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            PrintLogo();
            Console.Beep(600, 125);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            PrintLogo();
            Thread.Sleep(125);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            PrintLogo();
            Console.Beep(650, 400);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            PrintLogo();
            Thread.Sleep(125);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            PrintLogo();
            Console.Beep(700, 400);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            PrintLogo();
            Thread.Sleep(1000);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            PrintLogo();
            Console.Beep(500, 400);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            PrintLogo();
            Thread.Sleep(125);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            PrintLogo();
            Console.Beep(600, 400);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            PrintLogo();
            Thread.Sleep(125);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            PrintLogo();
            Console.Beep(700, 400);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            PrintLogo();
            Console.Beep(600, 500);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            PrintLogo();
            Thread.Sleep(500);
            Console.WriteLine("\n\n");
            string msgOne = "Ladies, Start Your Engines and May the Best Woman Win....";
            string msgTwo = "Press any Key to Continue";
            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + msgOne.Length / 2) + "}", msgOne);
            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + msgTwo.Length / 2) + "}", msgTwo);
            Console.ReadLine();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
