# Traffic-Light-Simulation

This is a VB.NET code for a traffic light simulation with some control features.

The traffic light simulation consists of three traffic lights (red, yellow, and green) that change colors depending on which button the user presses.
The code also includes a timer that controls the duration of each light color, as it cycles through the various lights.

The main components of the code are:
  + The Button Click Event handlers for the Red, Yellow, and Green buttons, which change the state of the traffic lights and invalidate the Panel control to trigger a repaint.
  + The Panel_Paint Event handler, which draws the traffic lights and traffic light frame.
  + The Graphics Class to draw the corresponding shapes and colors.
  + Timer control set
  + The Timer_Tick Event Handler that cycles through the various light states.
