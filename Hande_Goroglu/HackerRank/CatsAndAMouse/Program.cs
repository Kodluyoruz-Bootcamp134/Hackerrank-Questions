using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) 
    {

        var output = "Mouse C";
            var q = int.Parse(Console.ReadLine());
            for (int a0 = 0; a0 < q; a0++)
            {
                var tokens_x = Console.ReadLine().Split(' ');
                var catALocation = int.Parse(tokens_x[0]);
                var catBLocation = int.Parse(tokens_x[1]);
                var mouseLocation = int.Parse(tokens_x[2]);

                if (catALocation < catBLocation)
                {
                    if (catBLocation <= mouseLocation)
                    {
                        
                        output = "Cat B";
                    }
                    else
                    {
                        if (mouseLocation > catALocation)
                        {
                            
                            if (mouseLocation - catALocation > catBLocation - mouseLocation)
                                output = "Cat B";
                            else if (mouseLocation - catALocation < catBLocation - mouseLocation)
                                output = "Cat A";
                            else
                                output = "Mouse C";
                        }
                        else
                        {
                           
                            output = "Cat A";
                        }

                    }

                }
                else if (catALocation > catBLocation)
                {
                    if (catALocation <= mouseLocation)
                    {
                        
                        output = "Cat A";
                    }
                    else
                    {
                        if (mouseLocation > catBLocation)
                        {
                            
                            if (catALocation - mouseLocation > mouseLocation - catBLocation)
                                output = "Cat B";
                            else if (catALocation - mouseLocation < mouseLocation - catBLocation)
                                output = "Cat A";
                            else
                                output = "Mouse C";
                        }
                        else
                        {
                            
                            output = "Cat B";
                        }

                    }
                }
                else
                {
                    
                    output = "Mouse C";
                }

                Console.WriteLine(output);
            }
        
    }
}
