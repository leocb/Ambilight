# Ambilight
A custom Ambilight solution

This project is a custom Ambilight solution for PC only (no HDMI)

it works by capturing the desktop using DXGI duplication API, then analyzing the pixels of the image and then sending the data required for the LEDs to update over USB CDC
This does **NOT** support HDMI capture

## Objectives:
- Low latency
- 60 FPS
- Easy to configure
- Free
