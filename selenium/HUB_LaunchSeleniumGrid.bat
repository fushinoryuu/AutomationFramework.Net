@ECHO OFF

TITLE Selenium Grid - HUB

ECHO Starting the HUB...
ECHO.
CD /Selenium
java -jar selenium-server-standalone-3.14.0.jar -role hub -hubConfig HUB_Config.json