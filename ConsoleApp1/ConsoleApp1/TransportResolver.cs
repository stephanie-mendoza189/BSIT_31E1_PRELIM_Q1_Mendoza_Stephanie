namespace TransportChallenge;

public static class TransportResolver
{

    public static Vehicle? Resolve(string input)
    {
        

        if (string.IsNullOrEmpty(input))
        {
            return null;
        }

        
        string choice = input.ToLower().Trim();

        if (choice == "car")
        {
            return new Car();
        }
        else if (choice == "plane")
        {
            return new Airplane();
        }
        else if (choice == "boat")
        {
            return new Boat();
        }
        else if (choice == "helicopter")
        {
            return new Helicopter();
        }
        else
        {
            
            return null;


        }


    }


}
