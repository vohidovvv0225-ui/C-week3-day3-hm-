     Laptop laptop = new Laptop();

        laptop.Ram = 8;
        laptop.Storage = 256;
        laptop.Keyboard = "RGB Keyboard";
        laptop.Weight = 1.5;

        laptop.AddRam(8);
        laptop.AddStorage(256);

        Console.WriteLine("RAM: " + laptop.Ram + " GB");
        Console.WriteLine("Storage: " + laptop.Storage + " GB");
        Console.WriteLine("Keyboard: " + laptop.Keyboard);
        Console.WriteLine("Weight: " + laptop.Weight + " kg");

        laptop.WeightCheck();




   Smartphone phone = new Smartphone();

        phone.TakeSelfies();
        phone.TakeSelfies();
        phone.TakeSelfies();


        