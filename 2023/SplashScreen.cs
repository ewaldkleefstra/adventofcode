
using System;

namespace AdventOfCode.Y2023;

class SplashScreenImpl : SplashScreen {

    public void Show() {

        var color = Console.ForegroundColor;
        Write(0xcc00, false, "           ▄█▄ ▄▄█ ▄ ▄ ▄▄▄ ▄▄ ▄█▄  ▄▄▄ ▄█  ▄▄ ▄▄▄ ▄▄█ ▄▄▄\n           █▄█ █ █ █ █ █▄█ █ █ █   █ █ █▄ ");
            Write(0xcc00, false, " █  █ █ █ █ █▄█\n           █ █ █▄█ ▀▄▀ █▄▄ █ █ █▄  █▄█ █   █▄ █▄█ █▄█ █▄▄  sub y{2023}\n            \n");
            Write(0xcc00, false, "                                                            \n                                       ");
            Write(0xcc00, false, "                     \n                                                            \n                 ");
            Write(0xcc00, false, "                                           \n                                                        ");
            Write(0xcc00, false, "    \n                                                            \n                                  ");
            Write(0xcc00, false, "                          \n                                                            \n            ");
            Write(0xcc00, false, "                                                \n                                                   ");
            Write(0xcc00, false, "         \n                                                            \n                             ");
            Write(0xcc00, false, "                               \n                                                            \n       ");
            Write(0xcc00, false, "                                                     \n                                              ");
            Write(0xcc00, false, "              \n                                                            \n           ");
            Write(0x333333, false, "                                           *       ");
            Write(0x666666, false, " 5\n                                                            \n                                    ");
            Write(0x666666, false, "          *               ");
            Write(0xcccccc, false, " 4 ");
            Write(0x666666, false, "**\n                                                            \n                                    ");
            Write(0x666666, false, "                        \n                                                            \n              ");
            Write(0x666666, false, "                            *                   ");
            Write(0xcccccc, false, " 3 ");
            Write(0x666666, false, "**\n                                 *                            ");
            Write(0xcccccc, false, " 2 ");
            Write(0x666666, false, "**\n             *                                                ");
            Write(0xcccccc, false, " 1 ");
            Write(0x666666, false, "**\n           \n");
            
        Console.ForegroundColor = color;
        Console.WriteLine();
    }

   private static void Write(int rgb, bool bold, string text){
       Console.Write($"\u001b[38;2;{(rgb>>16)&255};{(rgb>>8)&255};{rgb&255}{(bold ? ";1" : "")}m{text}");
   }
}
