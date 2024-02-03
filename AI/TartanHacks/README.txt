README


EnRoute

EnRoute is an application which aids the elderly in their daily commutes. It provides audio and visual cues about a person's surroundings, based on multiple classification techniques.

How it works

EnRoute contains 4 files, all used for different classification purposes. 
1. The first file implements object detection and depth perception, to classify items like cars, trees, and animals. It uses a pre-trained version of the YOLOv5 model, with custom training datasets to provide more broad and accurate classifications. 
2. The second file implements human facial recognition for classification of people and crowds. We use Google's MediaPipe human facial recognition algorithm and combine it with depth-perception algorithms to achieve real-time classification and distance-estimation of people around the subject.
3. The third file implements edge-case recognition for major obstacles, currently trained to work with potholes and staircases. This also implements a custom-trained YOLOv5 model for fine-tuning and specific focus on such dangers. The next steps are to train the model for more such obstacles, like construction sites and sudden edges/drops.
4. The fourth file implements audio classification for sudden, alerting noises, including sirens, barking, accelerating cars, and more. We use the YAMNet model and custom datasets to improve the classification accuracy of the model, and to include more relevant classes such as shouting, revving, and more. 

Usage

These models will work in tandem with our app, where the outputs of these models will be delivered in an easy, accessible manner.   