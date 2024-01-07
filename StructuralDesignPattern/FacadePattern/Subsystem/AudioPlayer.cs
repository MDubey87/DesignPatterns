namespace FacadePattern.Subsystem
{
    /// <summary>
    /// Subsystem 1: AudioPlayer
    /// </summary>
    public class AudioPlayer
    {
        public void PlayAudio(string audioFile)
        {
            Console.WriteLine("Playing audio: " + audioFile);
        }
    }
}
