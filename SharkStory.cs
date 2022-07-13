using System;

public class SharkStory
{
  public static string Shark(
            int pontoonDistance, 
            int sharkDistance, 
            int yourSpeed, 
            int sharkSpeed, 
            bool dolphin)
  {
      // Retrieve the correct shark speed
      var sharkSpeedUpdated = IsSharkAttacked(dolphin, sharkSpeed);

      // Return the result
      if (ElaborateTime(pontoonDistance, yourSpeed) >= ElaborateTime(sharkDistance, sharkSpeedUpdated))
          return "Shark Bait!";
      else
          return "Alive!";
  }

  /// <summary>
  /// Calculate the time to complete the distance
  /// </summary>
  private static decimal ElaborateTime(decimal distance, decimal speed) => Decimal.Divide(distance, speed);

  /// <summary>
  /// Calculate the shark speed based on the attack
  /// </summary>
  private static decimal IsSharkAttacked(bool dolphin, int sharkSpeed)
  {
      // Half the speed in case the shark is attacked
      if (dolphin)
          return (decimal)sharkSpeed / 2;

      return sharkSpeed;
  }
}