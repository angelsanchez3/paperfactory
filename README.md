# PAPERFACTORY

This is a generator of paper folks.

## How to use

### Single Folk
1. Select a sources folder.
2. Select a destination folder.
3. Click *Generate* until you find a matching folk.
4. Click *Save* to give birth to a new folk!

### Bulk Folks
1. Select a sources folder.
2. Select a destination folder.
3. Select number of folks (current max: 50)
4. Click **Auto Generate** and wait for the whole family to be created!

## Project Structure
Form logic can be found in Form1.cs file.  
Randomizer logic can be found in AssetsRandomizer.cs

## Improvements

* Currently only assets for the background, hair, head (includes neck, ear, face and nose), eyes and lip are being randomized. Plus, only 4 sets of each exits.
* The generated CSV only saves high level information of the folk. It could save information related to each asset.
* Generating bulk folks is currently synchronous. When generating large bulks, the *Cancel* button should stop the generation.

## Other Remarks

TBD
