// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.Clear();

//LINE 1
Console.BackgroundColor = ConsoleColor.Cyan;
Console.SetCursorPosition(0,1);
Console.WriteLine("                                          ");//14(3)=42

//LINE 2
Console.SetCursorPosition(0,2);
Console.WriteLine("            ");//4(3)=12
Console.SetCursorPosition(12,2);
Console.BackgroundColor = ConsoleColor.Red;
Console.WriteLine("               ");//5(3)=15
Console.SetCursorPosition(27,2);
Console.BackgroundColor = ConsoleColor.Cyan;
Console.WriteLine("               ");//5(3)=15

//LINE 3
Console.SetCursorPosition(0,3);
Console.BackgroundColor = ConsoleColor.Cyan;
Console.WriteLine("         ");//3(3)=9
Console.SetCursorPosition(9,3);
Console.BackgroundColor = ConsoleColor.Red;
Console.WriteLine("                           ");//9(3)=27
Console.SetCursorPosition(36,3);
Console.BackgroundColor = ConsoleColor.Cyan;
Console.WriteLine("      ");//2(3)=6

//LINE 4
Console.SetCursorPosition(0,4);
Console.BackgroundColor = ConsoleColor.Cyan;
Console.WriteLine("         ");//3(3)=9
Console.SetCursorPosition(9,4);
Console.BackgroundColor = ConsoleColor.Black;
Console.WriteLine("         ");//3(3)=9
Console.SetCursorPosition(18,4);
Console.BackgroundColor = ConsoleColor.White;
Console.WriteLine("      ");//2(3)=6
Console.SetCursorPosition(24,4);
Console.BackgroundColor = ConsoleColor.Black;
Console.WriteLine("   ");//1(3)=3
Console.SetCursorPosition(27,4);
Console.BackgroundColor = ConsoleColor.White;
Console.WriteLine("   ");//1(3)=3
Console.SetCursorPosition(30,4);
Console.BackgroundColor = ConsoleColor.Cyan;
Console.WriteLine("            ");//4(3)=12

//LINE 5
Console.SetCursorPosition(0,5);
Console.BackgroundColor = ConsoleColor.Cyan;
Console.WriteLine("      ");//2=6
Console.SetCursorPosition(6,5);
Console.BackgroundColor = ConsoleColor.Black;
Console.WriteLine("   ");//1=3
Console.SetCursorPosition(9,5);
Console.BackgroundColor = ConsoleColor.White;
Console.WriteLine("   ");//1=3
Console.SetCursorPosition(12,5);
Console.BackgroundColor = ConsoleColor.Black;
Console.WriteLine("   ");//1=3
Console.SetCursorPosition(15,5);
Console.BackgroundColor = ConsoleColor.White;
Console.WriteLine("         ");//3=9
Console.SetCursorPosition(24,5);
Console.BackgroundColor = ConsoleColor.Black;
Console.WriteLine("   ");//1=3
Console.SetCursorPosition(27,5);
Console.BackgroundColor = ConsoleColor.White;
Console.WriteLine("         ");//3=9
Console.SetCursorPosition(36,5);
Console.BackgroundColor = ConsoleColor.Cyan;
Console.WriteLine("      ");//2=6

//LINE 6
Console.SetCursorPosition(0,6);
Console.WriteLine("      ");//2=6
Console.SetCursorPosition(6,6);
Console.BackgroundColor = ConsoleColor.Black;
Console.WriteLine("   ");//1=3
Console.SetCursorPosition(9,6);
Console.BackgroundColor = ConsoleColor.White;
Console.WriteLine("   ");//1=3
Console.SetCursorPosition(12, 6);
Console.BackgroundColor = ConsoleColor.Black;
Console.WriteLine("      ");//2=6
Console.SetCursorPosition(18,6);
Console.BackgroundColor = ConsoleColor.White;
Console.WriteLine("         ");//3=9
Console.SetCursorPosition(27,6);
Console.BackgroundColor = ConsoleColor.Black;
Console.WriteLine("   ");//1=3
Console.SetCursorPosition(30,6);
Console.BackgroundColor = ConsoleColor.White;
Console.WriteLine("         ");//3=9
Console.SetCursorPosition(39,6);
Console.BackgroundColor = ConsoleColor.Cyan;
Console.WriteLine("   ");//1=3

//LINE 7
Console.SetCursorPosition(0,7);
Console.WriteLine("      ");//2=6
Console.SetCursorPosition(6,7);
Console.BackgroundColor = ConsoleColor.Black;
Console.WriteLine("      ");//2=6
Console.SetCursorPosition(12,7);
Console.BackgroundColor = ConsoleColor.White;
Console.WriteLine("            ");//4=12
Console.SetCursorPosition(24,7);
Console.BackgroundColor = ConsoleColor.Black;
Console.WriteLine("            ");//4=12
Console.SetCursorPosition(36,7);
Console.BackgroundColor = ConsoleColor.Cyan;
Console.WriteLine("      ");//2=6

//LINE 8
Console.SetCursorPosition(0,8);
Console.WriteLine("            ");//4=12
Console.SetCursorPosition(12,8);
Console.BackgroundColor = ConsoleColor.White;
Console.WriteLine("                     ");//7=21
Console.SetCursorPosition(33,8);
Console.BackgroundColor = ConsoleColor.Cyan;
Console.WriteLine("         ");//3=9

//LINE 9
Console.SetCursorPosition(0,9);
Console.WriteLine("         ");//3=9
Console.SetCursorPosition(9,9);
Console.BackgroundColor = ConsoleColor.Blue;
Console.WriteLine("      ");//2=6
Console.SetCursorPosition(15,9);
Console.BackgroundColor = ConsoleColor.Red;
Console.WriteLine("   ");//1=3
Console.SetCursorPosition(18,9);
Console.BackgroundColor = ConsoleColor.Blue;
Console.WriteLine("         ");//3=9
Console.SetCursorPosition(27,9);
Console.BackgroundColor = ConsoleColor.Cyan;
Console.WriteLine("               ");//5=15

//LINE 10
Console.SetCursorPosition(0,10);
Console.WriteLine("      ");//2=6
Console.SetCursorPosition(6,10);
Console.BackgroundColor = ConsoleColor.Blue;
Console.WriteLine("         ");//3=9
Console.SetCursorPosition(15,10);
Console.BackgroundColor = ConsoleColor.Red;
Console.WriteLine("   ");//1=3
Console.SetCursorPosition(18,10);
Console.BackgroundColor = ConsoleColor.Blue;
Console.WriteLine("      ");//2=6
Console.SetCursorPosition(24,10);
Console.BackgroundColor = ConsoleColor.Red;
Console.WriteLine("   ");//1=3
Console.SetCursorPosition(27,10);
Console.BackgroundColor = ConsoleColor.Blue;
Console.WriteLine("         ");//3=9
Console.SetCursorPosition(30,10);
Console.BackgroundColor = ConsoleColor.Cyan;
Console.WriteLine("      ");//2=6

//LINE 11
Console.SetCursorPosition(0,11);
Console.WriteLine("   ");//1=3
Console.SetCursorPosition(3,11);
Console.BackgroundColor = ConsoleColor.Blue;
Console.WriteLine("            ");//4=12
Console.SetCursorPosition(15,11);
Console.BackgroundColor = ConsoleColor.Red;
Console.WriteLine("   ");//1=3
Console.SetCursorPosition(18,11);
Console.BackgroundColor = ConsoleColor.Blue;
Console.WriteLine("      ");//2=6
Console.SetCursorPosition(24,11);
Console.BackgroundColor = ConsoleColor.Red;
Console.WriteLine("   ");//1=3
Console.SetCursorPosition(27,11);
Console.BackgroundColor = ConsoleColor.Blue;
Console.WriteLine("            ");//4=12
Console.SetCursorPosition(39,11);
Console.BackgroundColor = ConsoleColor.Cyan;
Console.WriteLine("   ");//1=3

//LINE 12
Console.SetCursorPosition(0,12);
Console.WriteLine("   ");//1=3
Console.SetCursorPosition(3,12);
Console.BackgroundColor = ConsoleColor.White;
Console.WriteLine("      ");//2=6
Console.SetCursorPosition(9,12);
Console.BackgroundColor = ConsoleColor.Blue;
Console.WriteLine("      ");//2=6
Console.SetCursorPosition(15,12);
Console.BackgroundColor = ConsoleColor.Red;
Console.WriteLine("            ");//4=12
Console.SetCursorPosition(27,12);
Console.BackgroundColor = ConsoleColor.Blue;
Console.WriteLine("      ");//2=6
Console.SetCursorPosition(33,12);
Console.BackgroundColor = ConsoleColor.White;
Console.WriteLine("      ");//2=6
Console.SetCursorPosition(39,12);
Console.BackgroundColor = ConsoleColor.Cyan;
Console.WriteLine("   ");//1=3

//LINE 13
Console.SetCursorPosition(0,13);
Console.WriteLine("   ");//1=3
Console.SetCursorPosition(3,13);
Console.BackgroundColor = ConsoleColor.White;
Console.WriteLine("         ");//3=9
Console.SetCursorPosition(12,13);
Console.BackgroundColor = ConsoleColor.Red;
Console.WriteLine("   ");//1=3
Console.SetCursorPosition(15,13);
Console.BackgroundColor = ConsoleColor.Yellow;
Console.WriteLine("   ");//1=3
Console.SetCursorPosition(18,13);
Console.BackgroundColor = ConsoleColor.Red;
Console.WriteLine("      ");//2=6
Console.SetCursorPosition(24,13);
Console.BackgroundColor = ConsoleColor.Yellow;
Console.WriteLine("   ");//1=3
Console.SetCursorPosition(27,13);
Console.BackgroundColor = ConsoleColor.Red;
Console.WriteLine("   ");//1=3
Console.SetCursorPosition(30,13);
Console.BackgroundColor = ConsoleColor.White;
Console.WriteLine("         ");//3=9
Console.SetCursorPosition(39,13);
Console.BackgroundColor = ConsoleColor.Cyan;
Console.WriteLine("   ");//1=3

//LINE 14
Console.SetCursorPosition(0,14);
Console.WriteLine("   ");//1=3
Console.SetCursorPosition(3,14);
Console.BackgroundColor = ConsoleColor.White;
Console.WriteLine("      ");//2=6
Console.SetCursorPosition(9,14);
Console.BackgroundColor = ConsoleColor.Red;
Console.WriteLine("                        ");//8=24
Console.SetCursorPosition(33,14);
Console.BackgroundColor = ConsoleColor.White;
Console.WriteLine("      ");//2=6
Console.SetCursorPosition(39,14);
Console.BackgroundColor = ConsoleColor.Cyan;
Console.WriteLine("   ");//1=3

//LINE 15
Console.SetCursorPosition(0,15);
Console.WriteLine("         ");//3=9
Console.SetCursorPosition(9,15);
Console.BackgroundColor = ConsoleColor.Red;
Console.WriteLine("         ");//3=9
Console.SetCursorPosition(18,15);
Console.BackgroundColor = ConsoleColor.Cyan;
Console.WriteLine("      ");//2=6
Console.SetCursorPosition(24,15);
Console.BackgroundColor = ConsoleColor.Red;
Console.WriteLine("         ");//3=9
Console.SetCursorPosition(33,15);
Console.BackgroundColor = ConsoleColor.Cyan;
Console.WriteLine("         ");//3=9

//LINE 16
Console.SetCursorPosition(0,16);
Console.WriteLine("      ");//2=6
Console.SetCursorPosition(6,16);
Console.BackgroundColor = ConsoleColor.Black;
Console.WriteLine("         ");//3=9
Console.SetCursorPosition(15,16);
Console.BackgroundColor = ConsoleColor.Cyan;
Console.WriteLine("         ");//3=9
Console.SetCursorPosition(24,16);
Console.BackgroundColor = ConsoleColor.Black;
Console.WriteLine("         ");//3=9
Console.SetCursorPosition(33,16);
Console.BackgroundColor = ConsoleColor.Cyan;
Console.WriteLine("         ");//3=9

//LINE 17
Console.SetCursorPosition(0,17);
Console.WriteLine("   ");//1=3
Console.SetCursorPosition(3,17);
Console.BackgroundColor = ConsoleColor.Black;
Console.WriteLine("            ");//4=12
Console.SetCursorPosition(15,17);
Console.BackgroundColor = ConsoleColor.Cyan;
Console.WriteLine("         ");//3=9
Console.SetCursorPosition(24,17);
Console.BackgroundColor = ConsoleColor.Black;
Console.WriteLine("            ");//4=12
Console.SetCursorPosition(36,17);
Console.BackgroundColor = ConsoleColor.Cyan;
Console.WriteLine("      ");//2=6

//LINE 18
Console.SetCursorPosition(0,18);
Console.WriteLine("                                          ");//14=42










