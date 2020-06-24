# Solor-System-Stability
Physics Project

# Summary:
This is a simulation for the stability of planets falling at random into orbit around a singular stationary star. The program tests according to random variables whether the newly formed solar system is stable by seeing if it will remain as a functioning solar system for a given amount of time. 

The failure criterion for this project is if a planet escapes the gravitional pull of the sun (defined by the user as the radius of the solar system) or if a planet crashes directing into the center of the sun (this means a planet can skim the edges of the sun and the test will not fail as this would have introduced biase to the random variables).

All planets will always start with a velocity lower than its escape velocity. The concept being tested here is the conversation of energy as the forces move kinetic and potential energy from one object to another, which would cause solar system to fail.


# Values:
G is 1e17 times greater in this simulation so that the tests do not take ages.
The stationary sun has mass 2e6 and the relative mass of the earth comapred to the sun is 5. 
No planet can have a mass greater than the sun.


# Controls:

The variables on the menu screen are self explanatory, except for number of tests. This simply refers to how many iterations of the simulation you want to undergo.

Inside the simulation, the controls are as follows:
# Lshift: 
Pauses the scene and allows you to edit the time and enable / disable trails
# Rmouse: 
Reenters the scene from the paused state and locks the mouse.
# Space: 
Controls whether you want the simulation to regenerate after the time to call successful is passed. 
          NB: If the simulation reaches a fail criterion, the scene will still automatically switch
# Backspace: 
Skips to the next simulation, but counts the last one as a fail
# esc: 
Exits all tests early, but still retains data and how many simulations were run.

# the time: 
This speeds up the simulation by upto a factor of 99x, note this can lead to graphical performance issues.


# Maximise reliability:
In order to maximise the reliablity of the test, the follow variables need to be set up:
Radius of solar system: 1e5
Time to call test as successful: as greater as possible, but from testing about 200+ returns more reliable data

# Calculations
The gravity is simulated using F = gMm / r^2 and this is applied to the objects consistantly with a fixed time interval.
The escape Velocity uses the equation V = sqrt(2GM/r) and this is applied to the object as soon as the simulations start.
The Sun will not move, as this can cause the entire solar system to drift, which could impede observing the system. 





