Video Link
    https://www.loom.com/share/6dde63ce5fd546af9c269889fe0b6609
    Video is longer than 5 min, due to difficulty navigating the XR
    simulator device.

VR Technical Issues

    While creating my project, I had issues when using my headset once 
    again, where my headset was seen as "unauthorized," so in the 
    testing phases of development, I was unable to interact with the 
    UI, and was not able to fully test collision for the garden, 
    leading to them being possibly buggy. Strangly as well, imported 
    assets don't fall when gravity is applied to them, and I'm not sure
    what the issue is for that. The seeds are able to fall, but the 
    tools and tomatoes are not.

Project Description - Gardeneer VR

    A Gardening Simulation that has a relaxing environment. Its goal 
    is to help people who are struggling to garden to learn how 
    plants function, using real plants with their needs and 
    requirements. Currently, Gardeneer has a night and day cycle using
    the skybox feature, where the sky fades into day and night, and the 
    directional light rotates to simulate the sun rising and setting. 
    The user spawns with 4 garden plots, a house that contains all 
    the tools, and seeds to plant into the garden plots. When planting 
    the seeds, they will then sprout after a given time, and if they are
    not watered using the watering can, they will die. The watering can
    can starts off spraying water to indicate to the user that they 
    are able to pick it up to spray water, and they don't need to 
    worry about getting water first. Then when picked up, the 
    watering can will be able to detect its rotation and stop spewing 
    water at a certain angle (can be changable). The harrow is a tool 
    to till the ground, but is currently not working. The lighting in 
    the house is a mixed of baked, and use of light probes, with the 
    fireplace and the candles giving off a warm light. There is other 
    furniture in the house, including hooks and hats, where the user 
    is also able to wear the hats themselves. The simulation's 
    environment shows trees, the house and the rain, which can be 
    turned off using the UI inside the house. Surrounding the plains 
    are mountains of varying sizes to show the user that they are in 
    a secluded place. The UI in the house can be used to restart 
    everything, and there is also a settings option, where the user 
    is able to change their handedness (left or righthanded) and turn 
    off the particles for rain, helping to aid in user comfortablility 
    to let the user decide how they would like to see everything. The 
    user also sees instructions right in the doorway, of which hand 
    does what and when they load in for the firs time, they have a 
    fade in, to not overwhelm them.

Complete Setup/Installation instructions

    Install Unity Hub using the 2022.3.44f1 editor version, follow its 
    instructions. Download this project and unzip the folder. In the 
    Unity Hub application, go to the dropdown next to "Add", select 
    "Add project from disk" and use the extracted folder. If you do not 
    have a headset, skip to the next paragraph down. In Unity, you then 
    have to go to "File -> Build Settings" and plug in your Headset. 
    After plugging it in, click "Refresh" next to "Run Device" and in 
    the drop down of "Default Device" you should see your Headset. Once 
    that is completed, click build and run below, and save your build 
    however you want.
    No headset: There is an XR Device Simulator under the XR tab in the 
    Hierarchy tab. Click to enable it at the top of the inspector tab 
    and click the play button at the top middle of the scene. You will 
    have less functionality, including not being able to see gravity 
    all the time and not being able to interact with the UI. 

Hardware/Software requirements

    Around 60 FPS, 71 batches, with 28.6K tris.

Future Development Roadmap

    Creating the garden to have plants grow from them using time from 
    the skybox. Having the skybox give off a time variable, so we can 
    use that as reference for all plants' time based growth. Have the 
    "Reset everything" button be a "Sleep til morning" button, where 
    the user can skip past the day and night to speed up the plant 
    growing process. Be able to cut down and replant trees to build 
    more furniture. Be able to place signs of what crop you have 
    growing. Rain sound effects that go away when disabling the rain. 
    Actual growing plants with instructions on how to properly take 
    care of them. Align the sky with the rotational sun.

