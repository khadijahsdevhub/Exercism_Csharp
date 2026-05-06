abstract class Character
{
    private string CharacterType;
    
    protected Character(string characterType)
    {
        this.CharacterType = characterType;
        //throw new NotImplementedException("Please implement the Character() constructor");
    }
    

    public abstract int DamagePoints(Character target);

    public virtual bool Vulnerable()
    {
         return false;
        // throw new NotImplementedException("Please implement the Character.Vulnerable() method"); 
    }

    public override string ToString()
    {
        return($"Character is a {CharacterType}");
        
        // throw new NotImplementedException("Please implement the Character.ToString() method");
    }
}

class Warrior : Character
{
    public Warrior() : base("Warrior")
    {
    }

    public override int DamagePoints(Character target)
    {
           if (target.Vulnerable())
        {
            return 10;
        }
        return 6;
       // throw new NotImplementedException("Please implement the Warrior.DamagePoints() method");
    }
}

class Wizard : Character
{
    
    private bool spellPrepared;
    
    public Wizard() : base("Wizard")
    {
         spellPrepared = false;
    }

    public override int DamagePoints(Character target)
    {
          if (spellPrepared)
        {
            return 12;
        }
        return 3;
        //throw new NotImplementedException("Please implement the Wizard.DamagePoints() method");
    }

    public override bool Vulnerable(){
        return !spellPrepared;
    }

    public void PrepareSpell()
    {
        spellPrepared = true;
        //throw new NotImplementedException("Please implement the Wizard.PrepareSpell() method");
    }
}
