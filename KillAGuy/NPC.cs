public class NPC(){
    public string name {get; set;}
    public int HP {get; set;}
    public int Strength {get; set;}
    public int MaxSpeed {get; set;}
    private int _currentSpeed;
    public int CurrentSpeed{ // known bug: the first attack always results in a speed of 0 and speed never goes down
        get {return _currentSpeed;}
        set {
            _currentSpeed = MaxSpeed;
        }
    }
    public float accuracy {get; set;}

    public void Attack(NPC target){
        target.CurrentSpeed = target.MaxSpeed;
        CurrentSpeed -= 1;
        Text WriteText = new();
        WriteText.Colour($"{name} has engaged {target.name}", ConsoleColor.Red);
        DealDamage(target, Strength);
    }

    void DealDamage(NPC damageTaker, int damage){
        Text WriteText = new();
        damageTaker.HP -= damage;
        WriteText.Colour($"{damageTaker.name} has taken {Strength} damage and now has {damageTaker.HP} health left.", ConsoleColor.Green);
        Console.ReadLine();
    }

    void SpeedDecision(){
        CurrentSpeed = MaxSpeed;
    }
}