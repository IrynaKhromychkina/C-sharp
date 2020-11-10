namespace BonusCalculation
{
    class BonusCalculation
    {
        public static bool AskForBonus (Positions position, int hours)
        {
            bool checkForBonus = false;

            if(hours >= (int)position)
            {
                checkForBonus = true;
            }
            return checkForBonus;
        }
    }
}
