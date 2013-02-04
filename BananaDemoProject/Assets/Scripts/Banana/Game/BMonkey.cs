using System;
using UnityEngine;

public class BMonkey : FSprite
{
	static int numFrames = 19;
	
	private int _frameCount = 0;
	private int _frameIndex = 0;
	private FAtlasElement[] _frameElements;
	
	public BMonkey () : base("Monkey_0")
	{
		_frameElements = new FAtlasElement[numFrames];
		
		FAtlasManager am = Futile.atlasManager;
		//of course there are way smarter ways to do this, but this is fast
		//it's a ping ponging animation, which is why I did it this way, it's not a straight loop
		_frameElements[0] = am.GetElementWithName("Monkey_0");
		_frameElements[1] = am.GetElementWithName("Monkey_1");
		_frameElements[2] = am.GetElementWithName("Monkey_2");
		_frameElements[3] = am.GetElementWithName("Monkey_3");
		_frameElements[4] = am.GetElementWithName("Monkey_4");	
		_frameElements[5] = am.GetElementWithName("Monkey_5");	
		_frameElements[6] = am.GetElementWithName("Monkey_6");	
		_frameElements[7] = am.GetElementWithName("Monkey_7");	
		_frameElements[8] = am.GetElementWithName("Monkey_8");	
		_frameElements[9] = am.GetElementWithName("Monkey_9");	
		_frameElements[10] = am.GetElementWithName("Monkey_8");	
		_frameElements[11] = am.GetElementWithName("Monkey_7");	
		_frameElements[12] = am.GetElementWithName("Monkey_6");	
		_frameElements[13] = am.GetElementWithName("Monkey_5");	
		_frameElements[14] = am.GetElementWithName("Monkey_4");	
		_frameElements[15] = am.GetElementWithName("Monkey_3");	
		_frameElements[16] = am.GetElementWithName("Monkey_2");	
		_frameElements[17] = am.GetElementWithName("Monkey_1");	
		_frameElements[18] = am.GetElementWithName("Monkey_0");	
	}
	
	override public void Redraw(bool shouldForceDirty, bool shouldUpdateDepth)
	{
		if(_frameCount % 2 == 0) //update every other frame, aka 30 fps
		{
			_frameIndex = (_frameIndex+1)%numFrames; //increment the frame but keep it wrapping
			this.element = _frameElements[_frameIndex];
		}
		
		_frameCount++;
		base.Redraw(shouldForceDirty, shouldUpdateDepth);
	}

}


