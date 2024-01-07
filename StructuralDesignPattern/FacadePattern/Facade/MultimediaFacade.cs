using FacadePattern.Subsystem;

namespace FacadePattern.Facade
{
    /// <summary>
    /// Facade: MultimediaFacade
    /// </summary>
    public class MultimediaFacade
    {
        private AudioPlayer audioPlayer;
        private VideoPlayer videoPlayer;
        private DisplaySystem displaySystem;

        public MultimediaFacade()
        {
            audioPlayer = new AudioPlayer();
            videoPlayer = new VideoPlayer();
            displaySystem = new DisplaySystem();
        }

        // Facade methods that provide a simpler interface
        public void PlayMusic(string audioFile)
        {
            audioPlayer.PlayAudio(audioFile);
        }

        public void PlayMovie(string videoFile)
        {
            videoPlayer.PlayVideo(videoFile);
        }

        public void DisplayContent(string content)
        {
            displaySystem.Display(content);
        }
    }
}
