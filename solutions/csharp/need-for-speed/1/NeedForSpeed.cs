class RemoteControlCar
{
    public int speed;
    public int batteryDrain;
    private int battery;
    private int distanceDriven;
    
    
    // TODO: define the constructor for the 'RemoteControlCar' class
    public RemoteControlCar(int speed, int batteryDrain){
        this.speed = speed;
        this.batteryDrain = batteryDrain;
        this.battery = 100;
        this.distanceDriven = 0;
        
    }

    public bool BatteryDrained()
    {
        return battery < batteryDrain;
        throw new NotImplementedException("Please implement the RemoteControlCar.BatteryDrained() method");
    }

    public int DistanceDriven()
    {
        return  distanceDriven;
        throw new NotImplementedException("Please implement the RemoteControlCar.DistanceDriven() method");
    }

    public void Drive()
    {
        if (battery < batteryDrain){
            return;
        }
        distanceDriven += speed;
        battery -= batteryDrain;
        
    }

    public static RemoteControlCar Nitro()
    {
       return new RemoteControlCar(50, 4);
        throw new NotImplementedException("Please implement the (static) RemoteControlCar.Nitro() method");
    }
}

class RaceTrack
{
    public int distance;
    
    // TODO: define the constructor for the 'RaceTrack' class
    public RaceTrack(int distance){
        this.distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        int maxDrives = 100 / car.batteryDrain;
        int maxDistance = maxDrives * car.speed;

        return maxDistance >= distance;
        throw new NotImplementedException("Please implement the RaceTrack.TryFinishTrack() method");
    }
}
