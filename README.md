# AnimeMachineEnglish
makes anime characters by stacking 300x400 images over each other. As a side note, emgu cv is legitimate trash so I'll probably remake this in python or something Basically, a shittier, english version of: http://khmix.sakura.ne.jp/download.shtml But it has to have this stupid license because emgu.cv is not only steaming heap of trash, it has strings attached >_>

If I get to making a python version of this, it could be pretty cool... though I feel it'll allow me to be EVEN LAZIER if I find a way to generate a 3d model, ???, profit.

I should probably mention that if you are going to build a release version, you'll have to copy the data folder over as well. You can grab the one from the debug folder or from the project directory. I'm genuinely surprised that visual studio can't do that automatically... I had to add a stupid xcopy command in the post-build section.

Turns out there's actually an algorithm for adding colors... two, actually.