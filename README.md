COMP2150  - Level Design
Due: 13th April 11.55pm
Value: 25%

Please read this document in its entirety before starting the assignment.
By completing this assignment, you will:
•	Gain experience using the iterative design process.
•	Grow your knowledge and understanding of industry-relevant prototyping and documentation practices.
•	Create a level and related documentation that could form a portfolio piece.
You are tasked with designing, prototyping and documenting a level based on an existing game system, using iterative design practices. This assignment requires no coding, and a framework for both the game and documentation have been provided for you in this repo.
Your level should teach the player the essential mechanics and dynamics of the game, achieving the design goals of Discovery, Drama, Challenge and Exploration. Your level should be a series of interesting, well-designed encounters that are the result of planning and prototyping your game using theory and practices taught in class.
The assignment includes two main deliverables: your Level built in Unity, and your Design Document that documents and justifies your use of an iterative design process to create your level.
Level
Your task is to design and build one level with three main sections. Imagine this is the second level of the game, where the player already knows the basic movement mechanics.
The first section of your level should introduce the player to the main mechanics of the level, while the second and third should increase challenge and complexity through dramatic pacing. All three sections should be distinct, but form a coherent/connected level. Your design process and rationale are to be presented in the Design Document.
Player Experience Goals
The level must consist of a series of well-planned encounters which together deliver on the following player experience goals. Refer back to the lecture notes and SGTA tasks for more details on how to achieve these goals.
Discovery: The level should facilitate the player’s discovery of mechanics and dynamics without written instruction. Mechanics should be introduced safely and individually in section 1, before the player must use them under pressure and in combination (to learn new dynamics) in later sections. You can assume the player already knows the controls.
Drama: The level should feature appropriate dramatic pacing. Each section should be divided into encounters that require the player to use their skills to complete a task.
Challenge: The level should challenge the player’s reflexes and problem-solving skills. Challenges should be presented via a dramatic arc of modulated difficulty, with moments of tension and relief, and moments of power.
Exploration: The level should be non-linear, inviting and facilitating the player to explore in different directions without them getting lost or becoming uncertain as to what to do next. Your aesthetic and layout choices should aid in this goal, creating a distinct and memorable feeling of space/place.
Objective
The level must contain three keys which the player must collect to open a door. When the player reaches this door with all three keys, they will complete the level. An “End of Game” scene has been provided in the “Scenes” folder for you to have the player transition to when they have reached this door. The door and keys in the template scene have already been set-up to work in this way, so you can simply relocate them to match your level design.
Features
The game implements a simple 2D platformer with combat mechanics. You are required to include the following features in your submission: 
•	Acid
•	Checkpoints
•	Chompers
•	Health Pickups
•	Keys
•	Moving Platforms
•	Passthrough Platforms
•	Spikes
•	Spitters
•	Weapon Pickup (Gun)
•	Weapon Pickup (Staff)
All of these items can be found as prefabs in the “Prefabs > Required” folder in the assignment repository. An additional folder, “Prefabs > Optional” contains other features that you can use if they serve your level design. You must not include features from other packages, games, or that you have created.
Difficulty
The entire level (from the start of section 1 to exiting the door at the end of section 3) should take approximately 5-6 minutes to play for a moderately-skilled player familiar with platformers. 
Framework
This repo contains a Unity Project called “Unity Project”. This is a modified version of Unity Technologies’ 2D Game Kit, built to help you focus on the assessment task itself. We will not mark any other Unity Projects in this repo.
The Unity Project contains a scene called “Main” within the Assets > Scenes folder. This is the scene that we will treat as your submitted level. Additional prototyping levels can also be included in your Unity project and will be inspected where appropriate for marking.
The “Main” scene is already set-up with a player avatar, an end-of-level door, and three keys for you to position when building your level. If you need to start your scene again, you can create a new one by pressing Kit Tools > Create New Scene. Make sure you name this scene appropriately.
![Image of the Create New Scene drop-down](images/newscene.png)
This framework has been made using Unity 2022.3.58f1. You must use this version of Unity for your assignment. Use of another version of Unity may result in your assignment being corrupted or prevent it from being marked entirely.
Design Document
Your Design Document must be 1500 words and discuss how your level design achieves the requirements above. It must include screenshots, storyboards and at least three forms of prototypes, discussed in the lectures (molecule diagrams, level maps, greyboxes, etc). Your design document should not only show these prototypes, but also provide justification as to why they were chosen and their role in your iterative design process.
Framework
This repository contains a file called DesignDocument.md. This is the template document for your design document. It contains the template text, including examples on how to insert images, as well as the required section headings and what content should be included. You should edit this file and replace the template text with your own. Make sure you address each section appropriately. 
Images for your design document, such as your screenshots, storyboards and evidence of your prototypes, should go inside the “DocImages” folder and be inserted into the Design Document where appropriate. Please see the template for how to insert images into the README.md file.
The Design Document can be opened in any text editor such as Visual Studio Code, or edited directly in browser. 
Submission
Your assignment is submitted via this repository. To indicate you have completed your project, you should make your final commit message “Final Submission”.
After the assignment due date, we will clone all assignment repositories and begin marking. Late submissions will be marked in accordance with the policy outlined in the unit guide. Assignments not submitted via the provided assignment repository on Github Classroom will not be marked.
To ensure your assignment is marked correctly, check the following before your final submission:
•	Your final level is named “Main” and located in the “Scenes” folder.
•	Your design document is complete as the DesignDocument.md file in your repository and displays correctly when opened on github.com.
•	All supporting images display correctly in the Design Document and have been pushed to the “DocImages” folder.
•	Any additional prototyping scenes such as testing arenas are named appropriately and in the Assets > Scenes > Additional Scenes folder.
Be sure to commit and push your work regularly. No sympathy will be shown if you do not push until the last second and something goes wrong. We will only be accepting assignments via this repo. Alternative submissions will not be considered.
Use of Generative AI
Generative AI tools can empower students in their writing and facilitate greater communication of the course concepts. If ChatGPT or writing tools such as Grammarly are part of your workflow, you must detail your use using the template in DesignDocument.md. This will allow your marker to evaluate whether your use of Generative AI is appropriate, and where marks can be awarded.
Failure to declare the use of these tools may result in penalties or reports of Academic Misconduct. Note that use of translation tools, etc. should also be declared. When in doubt, declare it!
The library has created resources on the use of Generative AI which can be found [here]( https://libguides.mq.edu.au/generativeai). 
Resources and Help
If you have any questions, please post them in the Level Design Discussion Forum on iLearn. For additional guidance, you can also refer to the Unity 2D Game Kit Guide.
Rubric
The assignment will be marked according to the following rubric. Broken or improperly submitted assignments may result in F-grades on the basis they cannot be marked. While spelling and grammar are not marked directly, poor written expression or document formatting may impact clarity content, and result in a loss of marks. 
Category	Grade	Criteria
Level Design
(40%)	HD	The beginning of the level expertly scaffolds learning of the game’s mechanics.  All other required elements are present, and the level is of specified length. 

Difficulty curve is well crafted and finely balanced, supported by pacing and challenge that demonstrates an insightful and creative approach to applying design principles.

Level design and configuration of the mechanics demonstrates an advanced understanding of design principles as well as a high-level of creativity, with balanced and consistent delivery of all player experience goals.
    D	The beginning of the level gives a good and complete overview of the game’s mechanics.  All other required elements are present, and the level is of specified length. 

Difficulty curve is well structured and balanced, supported by good pacing and challenge that shows considered understanding of design principles.

Level design and configuration of the mechanics demonstrates good understanding of design principles as well as creativity, with consistent delivery of all player experience goals.
    C	The beginning of the level introduces the player to all the core mechanics, but not all elements are well introduced.  All other required elements are present and the level is of specified length. 

Difficulty curve of the level broadly increases and modulates over time in line with design principles, yet may show minor pacing and balance issues.  

Level design and configuration of the mechanics demonstrates some understanding of design principles, with at least partial delivery of all player experience goals.
    P	The level introduces most of the core mechanics, but some mechanics may be missing or introduced at odd intervals. Level may be slightly too long or too short.

Difficulty curve shows variance, but pacing and challenge may stagnate or fluctuate too wildly.

Most player experience goals are addressed, but may not be fully realised.
    F	Many core mechanics may not be introduced. Game is significantly shorter or longer than specified.  Difficulty curve is not meaningfully present. The level design facilitates little to no support of the specified player experience goals. 
Iterative Design Process
(30%)	HD	Changes between prototypes and the final level are comprehensively documented and evidence a disciplined and considered iterative design process was undertaken, with a clear pathway of design artefacts from low to high fidelity.

Reflections on this process show excellent understanding of its benefits, and how iterative changes led to a stronger level design and better satisfaction of player experience goals. 

Discussion artfully and insightfully highlights further opportunities for iterative refinement.    
    D	Changes between prototypes and the final level are well documented and evidence a considered iterative design process was undertaken, with a range of design artefacts from low to high fidelity.

Reflections on this process show considered understanding of its benefits, and how iterative changes led to improvements in the level design and its satisfaction of player experience goals. 

Discussion shows insight in highlighting further opportunities for iterative refinement.    
    C	Changes between prototypes and the final level are documented with evidence an iterative design process was undertaken (at least one additional low fidelity prototype is showcased, beyond the required storyboards, molecule diagram and level maps).

Reflections on this process show understanding of its benefits, and how iterative changes led to improvements in the level design. 

The discussion highlights at least one clear opportunity for iterative refinement.    
    P	Documentation shows some evidence an iterative design process was undertaken, though this may be limited or hard to track between the presented prototypes and the final level.

Reflections on this process show understanding of its benefits, yet there may be confusion or vagueness around how or if design changes led to improvements in the level design. 

Discussion attempts to highlight an opportunity for iterative improvement, yet this may be obscure or missing obvious flaws in the design.
    F	Discussion or evidence of iterative design may be missing or incomplete. Changes between prototypes and final level are not clearly present. Iterative design evidence appears to have been made after the final level.
Design Discussion
(30%)	HD	Discussion of design shows an excellent understanding of how specific level design choices satisfy player experience goals. All goals are well justified with clear and relevant supporting screenshots.

Excellent documentation of core gameplay, with clear and well-crafted storyboards as well as insightful justification of the sequenced introduction of all mechanics.
    D	Discussion of design shows a considered understanding of how specific level design choices satisfy player experience goals. All goals are well justified with relevant supporting screenshots.

Great documentation of core gameplay, with clear and well-crafted storyboards as well as considered justification of the sequenced introduction of all mechanics. 
    C	Discussion of design shows a good understanding of how specific level design choices satisfy player experience goals. A genuine and thoughtful attempt is made to justify all goals with supporting screenshots.

Good documentation of core gameplay, with clear storyboards and a fair justification for the sequenced introduction of all mechanics.
    P	Discussion of design shows some understanding of how level design choices satisfy player experience goals, but may be overly descriptive or lack clarity. A genuine attempt is made to justify most goals with supporting screenshots. 

Documentation of core gameplay includes storyboards for most mechanics and an attempt at justification for their sequenced introduction. Some inconsistencies between documentation and final level that are not the result of iterative design may be present.
    F	Elements of design discussion are missing or incomplete. Discussion and design artefacts may not appear to relate to one another or the final level. 

 
