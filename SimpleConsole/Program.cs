using SimpleApp.Console;

var video = new Video() { Title = "Joker" };
var videoEncoder = new VideoEncoder();
var messageService = new MessageService();
var mailService = new MailService();

videoEncoder.VideoEncoded += messageService.OnVideoEncoded;
videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
videoEncoder.VideoEncoding += messageService.OnVideoEncoding;
videoEncoder.VideoEncoding += mailService.OnVideoEncoding;

videoEncoder.Encode(video);