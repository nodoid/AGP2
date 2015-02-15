using Android.Views;
using Android.Content;
using Android.Graphics;

namespace AGP2
{
    public class GameView : SurfaceView, ISurfaceHolderCallback
    {

        Bitmap bmp;
        ISurfaceHolder holder;

        public GameView(Context context)
            : base(context)
        {
            holder = Holder;

            holder.AddCallback(this);

            bmp = BitmapFactory.DecodeResource(Resources, Resource.Drawable.Icon);
        }

        protected override void OnDraw(Canvas canvas)
        {
            canvas.DrawColor(Color.Argb(255, 68, 119, 102));
            canvas.DrawBitmap(bmp, 50, 100, null);
        }

        public void SurfaceChanged(ISurfaceHolder holder, Format format, int width, int height)
        {

        }

        public void SurfaceCreated(ISurfaceHolder holder)
        {
            var c = holder.LockCanvas(null);
            OnDraw(c);
            holder.UnlockCanvasAndPost(c);
        }

        public void SurfaceDestroyed(ISurfaceHolder holder)
        {

        }
    }
}

