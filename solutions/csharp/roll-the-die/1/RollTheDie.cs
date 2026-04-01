public class Player
{
    Random random = new Random();
    
    public int RollDie()
    {
        int die = random.Next(1,19);
        return die;
        throw new NotImplementedException("Please implement the Player.RollDie() method");
    }

    public double GenerateSpellStrength()
    {
       
        double die = random.NextDouble() * 100;
        return die;
        throw new NotImplementedException("Please implement the Player.GenerateSpellStrength() method");
    }
}
