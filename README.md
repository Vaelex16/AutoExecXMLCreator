# AutoExecXMLCreator
Create FFXI Bots using Auto Exec

This applicaiton is used in conjucntion with Windower 4 and Auto Exec for FFXI.

It auto generates an XML file that allows you and anyone else you would like to add
to be able to control a second character using commands in using party, linkshell, or tell
chat.

The application comes with four base bot command lists (the four I typically use) to use as
templates that you can add onto, or learn with and make your own. To open them click File >
Open Command File. These bots are located in the installation directory that you chose when
installing the application.

Once you open or create a bot clicking the 'Generate XML' button prompts you for a save location
and file name. You cna save it in any directory you wish, however do note that for Auto Exec to
be able to find it, you will need to place it inside the Windower4/plugins/autoexec folder.

Once the file is saved in the correct location, boot up your character in ffxi.

Load the bot using the following command:
//ae load filename
replace filename with whatever you named your XML document.

Once the XML is loaded, you're good to go! 

**NOTE**

Each bot will always have the following four commands:

**follow** causes the bot to follow your character.

**rest** causes the bot to rest.

**assist** causes the bot to target your target.

**atk** causes the bot to engage the enemy (this can be a bit tricky if the bot isn't facing the target).
