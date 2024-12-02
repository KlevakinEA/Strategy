Game g = new Game(new Player(new Sword()));
while (true) if(g.Command()) break;




interface IWeapon
{
    public void UseWeapon();
}


class Sword: IWeapon
{
    public void UseWeapon() { Console.WriteLine("You finished using sword. An uneasy atmosphere filled room."); }
}


class Axe : IWeapon
{
    public void UseWeapon() { Console.WriteLine("You used axe. You restored something. Not hp. Something."); }
}


class Bow : IWeapon
{
    public void UseWeapon() { Console.WriteLine("You used bow. Darker. Yet darker."); }
}


class Player
{
    private protected IWeapon weapon;
    public Player(IWeapon weapon) { this.weapon = weapon; }
    public void Attack() { weapon.UseWeapon(); }
    public void SetWeapon(IWeapon weapon) { this.weapon = weapon; }
}


class Game
{
    private protected Player player;
    public Game(Player player) { this.player = player; }
    public bool Command()
    {
        string command = Console.ReadLine();
        if (command == "") { return true; }
        if (command == "Attack") { player.Attack(); }
        if (command == "Sword") { player.SetWeapon(new Sword()); }
        if (command == "Axe") { player.SetWeapon(new Axe()); }
        if (command == "Bow") { player.SetWeapon(new Bow()); }
        return false;
    }
}