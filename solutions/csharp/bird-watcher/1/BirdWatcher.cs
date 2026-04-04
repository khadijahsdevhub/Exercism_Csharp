class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
      return  new[] {0, 2, 5, 3, 7, 8, 4};
        throw new NotImplementedException("Please implement the (static) BirdCount.LastWeek() method");
    }

    public int Today()
    {
        Console.WriteLine(birdsPerDay[birdsPerDay.Length - 1]);
        return birdsPerDay[birdsPerDay.Length - 1];
        throw new NotImplementedException("Please implement the BirdCount.Today() method");
    }

    public void IncrementTodaysCount()
    {
          if (birdsPerDay.Length == 0)
    {
        return;
    }
        birdsPerDay[birdsPerDay.Length - 1]++;

    }

    public bool HasDayWithoutBirds()
    {
        foreach (int day in birdsPerDay){
            if (day == 0) {
                Console.WriteLine(day);
                return true;
            }         
        }
        return false;        
        throw new NotImplementedException("Please implement the BirdCount.HasDayWithoutBirds() method");
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int total = 0;
        for (int i = 0; i < numberOfDays; i++){
            total += birdsPerDay[i];
        }
        return total;
        throw new NotImplementedException("Please implement the BirdCount.CountForFirstDays() method");
    }

    public int BusyDays()
    {
        int busyDaysCount = 0;
        
        foreach (int day in birdsPerDay){         
            if (day >= 5) {
                busyDaysCount++;
            }
        }
            return busyDaysCount;
        throw new NotImplementedException("Please implement the BirdCount.BusyDays() method");
    }
}
