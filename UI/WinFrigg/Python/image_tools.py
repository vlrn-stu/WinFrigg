from PIL import Image
import os

# Stitch all images in directory top to bottom
def stitch_images(directory, output_path):
    images = [Image.open(os.path.join(directory, f)) for f in os.listdir(directory) if f.endswith('.png')]
    widths, heights = zip(*(i.size for i in images))

    total_height = sum(heights)
    max_width = max(widths)

    new_image = Image.new('RGB', (max_width, total_height))

    y_offset = 0
    for im in images:
        new_image.paste(im, (0, y_offset))
        y_offset += im.size[1]

    new_image.save(output_path)