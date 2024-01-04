// See https://aka.ms/new-console-template for more information


using FriendFace;

var profile = new Profile("","",0,"","","");
var view = new View(profile);

profile.GenerateProfile();

while (true)
view.MainView();



