public class Hero {
    public string Name;
    public int Health;
    public int Level;
    public int Experience;

    public Hero(string name, int health) {
        Name = name;
        Health = health;
        Level = 1;
        Experience = 0;
    }

    public void TakeDamage(int damage) {
        if (damage <= 0) {
            return;
        }

        Health -= damage;

        if (Health < 0) {
            Health = 0;
        }
    }
}