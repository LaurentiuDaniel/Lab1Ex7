/*Ex7
Scrieti un program care va verifica daca un numar citit de la tastatura este par sau
impar
 In cazul in care numarul este par, programul va afisa “par” iar in caz contrar, “impar”.*/

class Lab1Ex7
{

    static void Main()
    {

        int numarUser;

        Console.WriteLine("Introdu numarul dorit:");
        numarUser = int.Parse(Console.ReadLine());

        if (numarUser % 2 == 0)
        {
            Console.WriteLine("Numarul tau este par");
        }
        else
        {
            Console.WriteLine("Numarul tau este impar");
        }










    }






}



