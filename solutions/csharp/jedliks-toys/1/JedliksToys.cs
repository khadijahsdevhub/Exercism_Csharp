class RemoteControlCar
{
    public int batteryPercentage = 100;
    public int distanceDriven = 0;
    
    public static RemoteControlCar Buy()
    {
         RemoteControlCar car = new RemoteControlCar();
        return car;
        throw new NotImplementedException("Please implement the (static) RemoteControlCar.Buy() method");
    }

    public string DistanceDisplay()
    {
      
        return $"Driven {distanceDriven} meters";
        throw new NotImplementedException("Please implement the RemoteControlCar.DistanceDisplay() method");
    }

    public string BatteryDisplay()
    {
        if (batteryPercentage == 0){
            return "Battery empty";
        } 
        return $"Battery at {batteryPercentage}%";
        throw new NotImplementedException("Please implement the RemoteControlCar.BatteryDisplay() method");
    }

    public void Drive()
    {
       // if (batteryPercentage == 0) return;
        
         if (batteryPercentage > 0){
             distanceDriven += 20;
             batteryPercentage -= 1;
         }
        return;

  
        throw new NotImplementedException("Please implement the RemoteControlCar.Drive() method");
    }
}
