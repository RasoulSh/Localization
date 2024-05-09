Localization
Localization System including arabic and farsi support for Unity UI

This package uses a CSV file to gather texts of different languages for UI Texts and also it adds Arabic and Farsi support for Unity3D.


CSV file configuration: Your CSV file must be something like this:
![CSV file configuration](https://github.com/RasoulSh/Localization/assets/17119993/fb2b313f-4843-4fb1-895c-fa0145a1b4c0)

- Key Column: Every text must have a Key so that it can be defined in Unity Text components using its key. Note that the first column’s header should be named “Key”; do not use other names otherwise the file cannot be read.

- Language Columns: The other columns are for the languages which you are using in your application. The header name of each column should represent its language’s name.

- Supported Languages: English, Farsi, Spanish, Arabic, Chinese, French, Russian, Portuguese and Turkish are the supported languages. Note that you may not use language names other than the listed languages (the spelling of the header’s text must be one of the above language names).



Localization Configuration: You can access the localization config in GameConfig/Localization:
![image](https://github.com/RasoulSh/Localization/assets/17119993/c3259871-deeb-4b90-b096-d0078ef11371)
![image](https://github.com/RasoulSh/Localization/assets/17119993/d8b87394-df6a-4018-a8a8-9a5172681412)

Current Language: Initial language of the application
Latin Font: The font which you are using for latin alphabetics
Arabic Font: The font which you are using for arabic language
Farsi Font: The font which you are using for farsi language
Localization File: Reference your CSV file here



Localization Accessor: One instance of this component must be added to the scene in order to use localization.
![image](https://github.com/RasoulSh/Localization/assets/17119993/4f19d696-4a60-4c1d-841b-e1d4fe76103f)

Data: You must reference the config file here (config file’s path : Assets/GameConfig/Localization)

Localize Text: Localize Text component is derived from Unity UI Text component with localization ability and RTL fix.
![image](https://github.com/RasoulSh/Localization/assets/17119993/9e96be12-3082-44e6-b32f-935bf98f7dc4)

Localize Key: The Key of the desired text in the localization file
Don’t Change Alignment: If unchecked, in RTL languages the alignment will automatically set to RTL and vice versa. If checked this behaviour will be turned off.



Converting Unity Text to LocalizeText: You can convert Unity Text components to LocalizeText through Context Menu
![image](https://github.com/RasoulSh/Localization/assets/17119993/6dfae40a-3a40-4c1c-b4df-32cfcbfcc73e)


