# Build an Apartment VR Project for Android

This project is part of [Udacity](https://www.udacity.com "Udacity - Be in demand")'s [VR Developer Nanodegree](https://www.udacity.com/course/vr-developer-nanodegree--nd017). 

### Project Perks
- Custom assets, textures and sounds from the unity store and other places.
- Bonus: sounds of a static TV and urban city - they have been manipulated to be heard in the 3D space (to check it out, change the camera to be near the windows facing the street or in front of the TV).

### Bugs
On the bed (pillow), there are lighting artefacts I can’t solve. A pillow and part of the cover are always black. I baked with a lightmap resolution of 2,5,20,40 and 80 texels per unit. I uncompressed the lightmap at 40 textels p/unit but the bug remained — I reseted back to compressed lightmap. I also tried to make the texture mobile diffused - but no avail. Switched back to mobile unlit (lightmap supported).
For the first case, I believe it is possible due to the intersection of 3 different lights — an area light, a spotlight and another purple spotlight (pretending to be a point light, but with 180 degrees).

I hope you enjoy!

## Udacity questions
### How long it took to do this project?
4 and a half days - worked once per week.

### One thing I liked this project (or three)
I liked that I could edit and search new objects, textures and sounds outside of unity. I liked to scale and rotate differently the game objects. In addition, applying new materials was quite cool.

### One thing that was particularly challenging about the project
Making sure objects were not floating or trespassing others. With the apartment walls provided, I was not able to use vertex snapping.

## Custom free Assets 
### Skybox from [DUTCH360 HDR](https://www.dutch360hdr.com/shop/product-category/free-360-hdri/) assets
- DF360_001 [texture reduced to 1024 - low quality compression]

### Textures from [SketchupTexture](https://www.sketchuptextureclub.com/)
- Bamboo, Dark Fine Wood, Old Wall, Venetian Plaster, Reinassance Plaster, Super Dark Fine Wood, Parquet Medium 

### Sounds from [SoundBible.com](http://soundbible.com/tags-city.html)
- Urban city, TV Static

### Extra Furniture from the Unity Asset Store
- A nice sofa from _CASSDALLA _ArchViz Sofa Pack - Lite_ 
- A table glass from _QUADRANTE STUDIO _Simple Table Glass_
- Bag Chair from _ANATOLIY M. Bag Chair_
- Computer Chair from _ANATOLIY M. Chair FP-01_
- Round Carpets from _OLOF HAGELIN Round Carpet_
- Lamps from _NEW SOLUTION STUDIO Free PBR Lamps_
- Plants from _NOBIAX / YUGHUES Yughues Free Decorative Plants_
- Bicycle + Rack from _PIFLIK WCE - Bicycle_
- Single Bed from _KOBRA GAME STUDIOS Bed collection_

## Versions
- Unity 2017.1.0p4
- GVR Unity SDK v1.70.0
