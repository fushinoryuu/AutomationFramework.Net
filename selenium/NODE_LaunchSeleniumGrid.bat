@ECHO OFF

TITLE Selenium Grid - NODE

ECHO Starting the NODE...
ECHO.
CD /Selenium
java -jar selenium-server-standalone-3.14.0.jar -role node -nodeConfig NODE_Config.json