using Microsoft.Deployment.WindowsInstaller;
using System;
using System.Collections.Generic;
using System.IO;


namespace WindowsInstaller
{
    class Program
    {
        static void Main(string[] args)
        {
                           
                IEnumerable<ProductInstallation> installations = Microsoft.Deployment.WindowsInstaller.ProductInstallation.GetProducts(null, "s-1-1-0", UserContexts.All);
               

                // Step 3 - Loop through the installed MSI Products and output information

                while (true)
                {
                    foreach (ProductInstallation installation in installations)
                    {
                        Console.WriteLine(installation.ProductName);                        
                        Console.WriteLine(installation.ProductCode);
                        
                         
                    }
                    return;
                    
                    
                    
                }
                    
            }           
                              
          }        
        
    }


