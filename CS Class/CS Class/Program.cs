using System;

namespace CS_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1-ci ve 2-ci tapsiriq******************************************************************************************
            // Notebook class yaradın ve aşağıdakı xüsusiyyətləri olsun 
            // -Name - məhsulun adını ifadə edən xüsusiyyət
            // -BrandName - Notebook - un  brand adı
            // -Price - Notebook - un qiyməti.
            //1 - ci tapşırıqda yaratdığınız Notebook classindan bir notebook array - i duzeldin
            // Layihə işə düşdükdə bizdən minPrice dəyəri daxil etməyimizi və
            // daha sonra maxPrice dəyəri daxil etməyimizi istəsin.
            // Daha sonra yaratmış olduğumuz array-də minPrice və maxPrice
            // aralığında qiyməti olan notebookların adlarını console-a yazdırsız

            Notebook[] noteBooks=new Notebook[8];

            noteBooks[0] = new Notebook("Think Pad", "Lenovo", 1000);
            noteBooks[1] = new Notebook("Think Book", "Lenovo", 2000);
            noteBooks[2] = new Notebook("Air 300", "MacBook", 4000);
            noteBooks[3] = new Notebook("S21", "Predator", 3200);
            noteBooks[4] = new Notebook("Pavillion", "HP", 2700);
            noteBooks[5] = new Notebook("A1", "Asus", 1700);
            noteBooks[6] = new Notebook("Y3432", "Samsung", 700);
            noteBooks[7] = new Notebook("Flop22", "Floppier", 890);
        

            Console.WriteLine("Minimum qiymeti daxil edin : ");
            int minPrice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Maksimum qiymeti daxil edin : ");
            int maxPrice = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < noteBooks.Length; i++)
            {
                if (minPrice<noteBooks[i].Price && noteBooks[i].Price < maxPrice)
                {
                    Console.WriteLine($"{noteBooks[i].BrandName} {noteBooks[i].Name}");
                }
                else
                {

                }
            }
            #endregion

            #region 3-ci tapsiriq******************************************************************************************
            // Aşağıdaki parametrlərə sahib Car class yaradın
            //-Brand
            //- Model
            //- CurrentFuel - masinin hazirki benzin miqdari
            //- FuelFor1Km - masinin 1 km ucun xerclediyi benzin
            //-Millage - Masinin bu vaxtadək neçə km sürüldüyü
            //- Drive() - sürülmə metodu.Bu metod int parametr qeəbul edir(neçə km sürmək istədiyimiz)
            //Car obyekti yaradın drive metodunu işə saldıqda arqument olaraq neçə km sürmək istədyimizi daxil edirik
            //və əgər benzin kifayət edirsə maşının millage dəyəri və benzini azalır,
            //benzin kifayət etmirsə console - da xəta mesajı yazılır
            Console.WriteLine("******************************************** Car *********************************");
            Car car1 = new Car()
            {
                Brand = "Toyota",
                Model = "Camry",
                CurrentFuel = 20,
                FuelFor1Km = 1,
                Millage = 200,
            };

            car1.Drive(4);

           

            Console.WriteLine($"{car1.CurrentFuel} l benzin qalir");
            Console.WriteLine($"{car1.Millage} KM surulub");
            #endregion

        }
    }
}
