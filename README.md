# PintChecker

This tool can help you gather information’s about you internet connection. You can track your ping, jitter and data loss over time as well as the current Wi-Fi connection quality (strength). All data will be saved in a CSV file that you can later use to visualize you data and find fluctuations.

_FYI: While creating the project I made a typo and stayed with it ;-)_

Screenshots
-------
UI version

![Form Application][form]

Console application

![Console Application][console]

Output Example
-------

|Date	|Time	|Average	|Jitter	|DataLoss	|DataCorruption	|Host	|SSID	|Strength|
| ---- |----| -----| -----| -----| -----| -----| -----| -----|
|13.04.2015|	10:46:14|	19|	1|	0|	0|	google-public-dns-a.google.com|	borsi|	75 |
|13.04.2015|	10:46:18|	19|	1|	0|	0|	google-public-dns-a.google.com|	borsi|	75 |
|13.04.2015|	10:46:20|	19|	0|	0|	0|	google-public-dns-a.google.com|	borsi|	75 |
|13.04.2015|	10:46:22|	22|	11|	0|	0|	google-public-dns-a.google.com|	borsi|	48 |

Licence
-------

GNU GENERAL PUBLIC LICENSE V2

 [form]: https://raw.githubusercontent.com/jwillmer/PintChecker/master/form-preview.png
 [console]: https://raw.githubusercontent.com/jwillmer/PintChecker/master/console-preview.png
