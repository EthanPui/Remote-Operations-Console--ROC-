# Remote Operations Console (ROC)
 
###Conclusion:

All outcomes are successfully implemented, went through multiple API and libraries such as SFML.NET (C#), SFML (C++), DirectX, SharpLibHid, UWP, Xinput, RawInput, SharpDX, DirectInput,  (in order) before settling on using WPF and for joystick functionality (Windows.Gaming.Input). To use controller named Razor Ruiji Master, an external application DS4Windows needs to be installed and run during operation. This application allows windows to emulate the Razor Ruiji Master controller as an Xbox 360 Controller. Possible risks for the future is if UWP becomes a legacy software, however due to past actions from Microsoft it has a chance to still remain stable and work possibly in future environments.  

All outcomes are successfully implemented, I have added test MCU Client Program in my personal folder for future use and testing. ROC Master and test MCU Client program are able to send and receive functions over UDP. Thus, proving setup of ROC Server and connection to server for MCU Client is successful. We have decided to go with UDP rather than TCP as directed in the specification sheet due to current circumstances and scope of objective for the test/demonstration vehicle. 

Joystick controller “Emergency Stop” event and GUI “Emergency Stop” event has been successfully implemented, however the activation of theses actions currently does not set MCU operating mode to MCU Standby Mode. This is due to resource limitation (no physical MCU to work on).

All outcomes are successfully completed. Master Program layout is built to allow for future layout changes due to whole GUI being placed in one table layout. All buttons are setup with joystick inputs, left thumbstick and back left/right throttle are also set for non-holonomic drive. Output of these are shown in GUI. Joystick integration is done with WPF (Windows.Gaming.Input).

ROC_FIRMWARE	Roc master with GUI, displaying input from Joystick, written in C#, creates server with same port as MCU
MCU-CLIENT	Test Program acting as the MCU, written in C# responds and sends data packets with LREV_ROC_FIRMWARE program
ROC_State_Machine	Outlines the initial basic state machine for LREV_ROC_FIRMWARE
Joystick_Api_Report	Updated to include current knowledge of libraries available for joystick integration to ROC master


###Recommendations:

I recommend the process of going through all the cases for transitions between the states to clarify that the operating modes run bug free (create a state machine table that is thorough, clear and concise for future readability).

Look into future iteration of button allocation and the separation of inputs between the back and front buttons (currently some back buttons active the same inputs as some buttons in the front).

Further testing is required with final MCU and ROC connection. Current setup simulates the environment with C# for both ROC and MCU. Due to limitations of resources and time we are unable to test with the physical MCU as of yet, thus in future, testing with physical MCU will be needed.

Once physical MCU is available (assuming its using Linux operating system) figure out how to make it a client that connects to ROC Master server, then relay the joystick and GUI inputs to change MCU mode to Standby. 

Improvement of ROC GUI with future iterations is recommended, clean up of GUI with better visual feedback (use of sliders for steering and speedometer for motor power as a suggestion for visual feedback). Centering ROC and MCU state text or using images for states could be a visual improvement. Recommended after successful test to implement holonomic drive using a suitable control layout. 

