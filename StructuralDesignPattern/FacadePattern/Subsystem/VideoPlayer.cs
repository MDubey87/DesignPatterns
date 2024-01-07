namespace FacadePattern.Subsystem
{
    /// <summary>
    /// Subsystem 2: VideoPlayer
    /// </summary>
    public class VideoPlayer
    {
        public void PlayVideo(string videoFile)
        {
            Console.WriteLine("Playing video: " + videoFile);
        }
    }
}
