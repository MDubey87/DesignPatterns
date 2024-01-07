using FacadePattern.Facade;

MultimediaFacade multimedia = new MultimediaFacade();

// Using the facade to simplify interaction
multimedia.PlayMusic("song.mp3");
multimedia.PlayMovie("movie.mp4");
multimedia.DisplayContent("Welcome to our multimedia system!");

Console.ReadKey();