@ECHO OFF

TITLE Selenium Grid - NODE

ECHO Starting the NODE...
ECHO.
CD /Selenium
java -jar selenium-server-standalone-3.12.0.jar -role node -nodeConfig NODE_Config.json