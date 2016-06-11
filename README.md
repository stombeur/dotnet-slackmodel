# dotnet-slackmodel

A class library with the necessary classes to create Slack messages for Slack bots built in .NET

- SlackMessage
- SlackAttachment
- SlackField

Additionally, a few helper classes:

- Colors - _Good, Warning, Danger_
- ColorExtensions - _System.Drawing.Color.ToRgb (#RRGGBB)_
- Emoji - _string constants for +/- 1300 known emoji's_
- StringFormattingExtensions - _Pre(), Code(), AppendNewLine(), etc..._
- ModelExtensions - _SlackMessage.ToJObject() = serialize to json with the correct field names_