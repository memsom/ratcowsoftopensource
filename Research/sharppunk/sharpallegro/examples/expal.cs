using System;

using sharpallegro;

namespace expal
{
  class expal : Allegro
  {

    static int Main()
    {
      PALETTE palette = new PALETTE();
      RGB temp;
      int c;

      if (allegro_init() != 0)
        return 1;
      install_keyboard();
      if (set_gfx_mode(GFX_AUTODETECT, 320, 200, 0, 0) != 0)
      {
        if (set_gfx_mode(GFX_AUTODETECT, 640, 480, 0, 0) != 0)
        {
          allegro_message("Error setting graphics mode\n" + allegro_error);
          return 1;
        }
      }

      /* first set the palette to black to hide what we are doing */
      set_palette(black_palette);

      /* draw some circles onto the screen */
      acquire_screen();

      for (c = 255; c > 0; c--)
        circlefill(screen, SCREEN_W / 2, SCREEN_H / 2, c, c);

      release_screen();

      install_mouse();
      show_mouse(screen);

      /* fill our palette with a gradually altering sequence of colors */
      for (c = 0; c < 64; c++)
      {
        palette[c].r = (byte)c;
        palette[c].g = 0;
        palette[c].b = 0;
      }
      for (c = 64; c < 128; c++)
      {
        palette[c].r = (byte)(127 - c);
        palette[c].g = (byte)(c - 64);
        palette[c].b = 0;
      }
      for (c = 128; c < 192; c++)
      {
        palette[c].r = 0;
        palette[c].g = (byte)(191 - c);
        palette[c].b = (byte)(c - 128);
      }
      for (c = 192; c < 256; c++)
      {
        palette[c].r = 0;
        palette[c].g = 0;
        palette[c].b = (byte)(255 - c);
      }

      /* animate the image by rotating the palette */
      while (!keypressed())
      {
        temp = palette[255];
        for (c = 255; c > 0; c--)
          palette[c] = palette[c - 1];
        palette[0] = temp;
        set_palette(palette);
      }

      return 0;
    }

  }
}
