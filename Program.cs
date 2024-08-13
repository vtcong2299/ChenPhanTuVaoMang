using System;
using System.Diagnostics;


namespace TimGiaTriLonNhat
{
    class Program
    {
        
        static void Main(string[]args)
        {
            int quantityArray;
            int i;
            int index;
            int num;
            
            Console.WriteLine("Chen phan tu vao mang");
            Console.WriteLine("*********************");
            Console.Write("\nNhap vao so luong phan tu trong mang: ");
            while (true)
            {
                if(int.TryParse(Console.ReadLine(),out quantityArray)&& quantityArray>0)
                {
                    break;
                }
                else
                {
                    Console.Write("Nhap lai so luong phan tu trong mang: ");
                }
            }
            int [] array = new int [quantityArray+1];
            for(i=0;i<quantityArray;i++)
            {
                Console.Write("Nhap vao phan tu thu [{0}]: ", i);
                while(true)
                {
                    if(int.TryParse(Console.ReadLine(),out array[i]))
                    {
                        break;
                    }
                    else
                    {
                        Console.Write("Nhap lai phan tu thu [{0}]: ", i);
                    }
                }
                                    
            }
            Console.Write("Ta co mang hien tai: ");
            for(i=0;i<quantityArray;i++)
            {
                Console.Write("{0,5}", array[i]);
            }
           
            Console.Write("\nNhap vao gia tri muon chen: ");
            while (true)
                {
                if(int.TryParse(Console.ReadLine(),out num))
                {
                    break;
                }
                else
                {
                    Console.Write("Nhap lai gia tri muon chen: ");
                }
            }
            Console.Write("Nhap vao vi tri muon chen: ");
            while (true)
            {
                if(int.TryParse(Console.ReadLine(),out index)&& index>=0&& index <=quantityArray)
                {
                        
                    break;
                }
                else
                {
                    Console.Write("Nhap lai vi tri muon chen: ");
                }
            }
            
            for (i=quantityArray; i>=index;i--)
            {
                array[i]=array[i-1];

            }
                
            array[index -1]= num;
            Console.Write("Mang sau khi chen la: ");
            for(i=0;i<=quantityArray;i++)
            {
                Console.Write("{0,5}", array[i]);
            }               
           
        }
    }
}