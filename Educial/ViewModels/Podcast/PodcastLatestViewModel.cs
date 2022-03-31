namespace Educial.ViewModels.Podcast
{
    //https://github.com/adrianstevens/Xamarin-Plugins/blob/master/SimpleAudioPlayer/Samples/SAPlayerSample/SAPlayerSample/Pages/LibraryAudioPage.xaml.cs
    public class PodcastLatestViewModel : BaseViewModel
    {
        // private readonly ISimpleAudioPlayer player;
        public PodcastLatestViewModel()
        {
            Title = "Podcast";
            //AudioDuration = 1;
            //ShowPlayBtn = true;
            //ShowPauseBtn = false;
            //SeekAudioSliderCommand = new Command(SeekAudio);
            //StopPlayingButtonCommand = new Command(StopPlaying);
            //StartPlayButtonCommand = new Command(StartPlaying);
            //// player = CrossSimpleAudioPlayer.Current;
            //player.PlaybackEnded += Player_PlaybackEnded;
        }


        //private void Player_PlaybackEnded(object sender, System.EventArgs e)
        //{
        //    IsPlaying = false;
        //    ShowPauseBtn = false;
        //    ShowPlayBtn = true;
        //}

        //public Command SeekAudioSliderCommand { get; set; }
        //public Command StopPlayingButtonCommand { get; set; }
        //public Command StartPlayButtonCommand { get; set; }

        //#region Properties

        //private double seekPosition;

        //public double SeekPosition
        //{
        //    get => seekPosition;
        //    set => SetProperty(ref seekPosition, value);
        //}
        //private double audioDuration;
        //public double AudioDuration
        //{
        //    get => audioDuration;
        //    set => SetProperty(ref audioDuration, value);
        //}

        //private bool isPlaying;

        //public bool IsPlaying
        //{
        //    get => isPlaying;
        //    set => SetProperty(ref isPlaying, value);
        //}

        //private bool isBusy;

        //public bool IsBusy
        //{
        //    get => isBusy;
        //    set => SetProperty(ref isBusy, value);
        //}
        //private bool isPaused;

        //private bool showPlayBtn;

        //public bool ShowPlayBtn
        //{
        //    get => showPlayBtn;
        //    set => SetProperty(ref showPlayBtn, value);
        //}

        //private bool showPauseBtn;

        //public bool ShowPauseBtn
        //{
        //    get => showPauseBtn;
        //    set => SetProperty(ref showPauseBtn, value);
        //}


        //#endregion

        //private void TogglePlayState()
        //{
        //    if (isPaused)
        //    {
        //        player.Play();
        //        Device.StartTimer(TimeSpan.FromSeconds(0.5), UpdatePosition);
        //        ShowPauseBtn = true;
        //        ShowPlayBtn = false;
        //        Device.StartTimer(TimeSpan.FromSeconds(0.5), UpdatePosition);
        //    }
        //    else
        //    {
        //        player.Pause();
        //        ShowPauseBtn = false;
        //        ShowPlayBtn = true;
        //    }

        //    isPaused = !isPaused;
        //}
        //private async void StartPlaying()
        //{
        //    IsBusy = true;
        //    if (IsPlaying)
        //    {
        //        TogglePlayState();
        //    }
        //    else
        //    {
        //        Stream audioStream = await GetAudioFile("episode2");
        //        if (player != null & audioStream != null)
        //        {
        //            player.Load(audioStream);
        //            AudioDuration = player.Duration;
        //            player.Play();
        //            IsPlaying = true;
        //            ShowPauseBtn = true;
        //            ShowPlayBtn = false;
        //            Device.StartTimer(TimeSpan.FromSeconds(0.5), UpdatePosition);
        //        }
        //        else
        //        {
        //            await Application.Current.MainPage.DisplayToastAsync("Error playing this episode.", 1000);
        //        }
        //    }
        //    IsBusy = false;
        //}
        //private void StopPlaying()
        //{
        //    IsPlaying = !IsPlaying;
        //    player.Stop();
        //    ShowPauseBtn = false;
        //    ShowPlayBtn = true;
        //}
        //private void SeekAudio()
        //{
        //    if (!(Math.Abs(SeekPosition - player.Duration) > 0.01)) return;
        //    player.Seek(SeekPosition);
        //}

        //private static async Task<Stream> GetMusicStream(string url)
        //{
        //    var aRequest = (HttpWebRequest)WebRequest.Create(url);
        //    var aResponse = (HttpWebResponse)await aRequest.GetResponseAsync();
        //    return aResponse.GetResponseStream();
        //}

        //private async Task<Stream> GetAudioFile(string audioFile)
        //{
        //    string audioFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), audioFile + ".mp3");
        //    if (File.Exists(audioFilePath))
        //        return File.OpenRead(audioFilePath);
        //    const string url = "https://firebasestorage.googleapis.com/v0/b/helperx-1111.appspot.com/o/the-cradle-of-your-soul-15700.mp3?alt=media&token=5d099c43-15d8-4a4d-802e-2af85b14fbc4";
        //    await Application.Current.MainPage.DisplayToastAsync("Download Started.", 1000);
        //    bool result = await DownloadAndSaveFile(audioFilePath, url);
        //    if (result)
        //    {
        //        await Application.Current.MainPage.DisplayToastAsync("Download Finished.", 1000);
        //        return File.OpenRead(audioFilePath);
        //    }
        //    await Application.Current.MainPage.DisplayToastAsync("Download Failed.", 1000);
        //    return null;
        //}
        //private static async Task<bool> DownloadAndSaveFile(string audioFilePath, string downloadUrl)
        //{
        //    try
        //    {
        //        Stream stream = await GetMusicStream(downloadUrl);
        //        FileStream outputFileStream = new FileStream(audioFilePath, FileMode.Create);
        //        await stream.CopyToAsync(outputFileStream);
        //        outputFileStream.Dispose();
        //        stream.Dispose();
        //        return true;
        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //    }
        //}

        //private bool UpdatePosition()
        //{
        //    SeekPosition = player.CurrentPosition;
        //    return player.IsPlaying;
        //}

    }
}
