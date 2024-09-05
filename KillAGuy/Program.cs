static void Main(){
    NPCCollection c = new();

    while(c.LittleGuy.HP > 0 && c.EvilGuy.HP > 0){
        Console.WriteLine(c.LittleGuy.CurrentSpeed);
        Console.WriteLine(c.EvilGuy.CurrentSpeed);
        if (c.LittleGuy.CurrentSpeed > c.EvilGuy.CurrentSpeed){
            c.LittleGuy.Attack(c.EvilGuy);
        }
        else{
            c.EvilGuy.Attack(c.LittleGuy);
        }
    }
};

Main();