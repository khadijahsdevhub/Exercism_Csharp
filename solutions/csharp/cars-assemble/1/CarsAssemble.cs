static class AssemblyLine
{

   
    public static double SuccessRate(int speed)
    {
        if (speed == 0)
        {
            return 0/100;  
        }
        else if (speed <= 4)
        {
            return 100/100;
        } 
        else if (speed > 4 && speed <= 8){
            return 0.9;
        }
        else if (speed == 9){
            return 0.8;
        }
        else if (speed == 10){
            return 0.77;
        } 
        else
        {
            Console.WriteLine("Invalid input");
        }
        throw new NotImplementedException("Please implement the (static) AssemblyLine.SuccessRate() method");
    }
    
    public static double ProductionRatePerHour(int speed)
    {
        int total =  221 * speed;
        if (speed == 0)
        {
            return total * 0;  
        }
        else if (speed <= 4)
        {
            return (100/100) *total;
        }
        else if (speed > 4 && speed <= 8)
        {
            return 0.9 * total;
        }
        else if (speed == 9)
        {
            return 0.8* total;
        }
        else if (speed == 10)
        {
            return 0.77 * total;
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
           
        throw new NotImplementedException("Please implement the (static) AssemblyLine.ProductionRatePerHour() method");
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        int total =  221 * speed;
        if (speed == 0)
        {
            double rate =  total * 0; 
            double workingCarsPerMinute = rate / 60;
            return (int) workingCarsPerMinute;
        }
        else if (speed <= 4)
        { 
            
            double rate =  (100/100) *total; 
            double workingCarsPerMinute = rate / 60;
            return (int) workingCarsPerMinute;
        }
        else if (speed > 4 && speed <= 8)
        {
             
            double rate =  0.9 * total; 
            double workingCarsPerMinute = rate / 60;
            return (int) workingCarsPerMinute;
        }
        else if (speed == 9)
        {
             
            double rate =  0.8* total; 
            double workingCarsPerMinute = rate / 60;
            return (int) workingCarsPerMinute;
        }
        else if (speed == 10)
        {
             
            double rate =  0.77 * total; 
            double workingCarsPerMinute =  rate / 60;
            return (int) workingCarsPerMinute;
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
        
        throw new NotImplementedException("Please implement the (static) AssemblyLine.WorkingItemsPerMinute() method");
    }
}
