namespace FacadePattern.Subsystem
{
    /// <summary>
    /// Subsystem 3: DisplaySystem
    /// </summary>
    public class DisplaySystem
    {
        public void Display(string displayContent)
        {
            Console.WriteLine("Displaying: " + displayContent);
        }
    }
}
