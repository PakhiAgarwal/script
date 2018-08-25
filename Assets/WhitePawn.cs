﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;  

public class WhitePawn : Piece {
	public override void CheckValidMoves()
	{
		validMoves.Clear (); 
		foreach (Square j in TheCanvas.AllSquares) 
		{
			if (((this.movesMade == 0) && ((j.indRow == (this.indRow + 2)) && (j.indCol == this.indCol)) && (TheCanvas.AllSquares [this.indRow +1, this.indCol].gameObject.transform.childCount == 0)) && (j.gameObject.transform.childCount == 0)) 
			{
				validMoves.Add (j); 
			}
			else if ((((j.indRow == (this.indRow + 1)) && (j.indCol == (this.indCol - 1)) && (j.gameObject.transform.childCount !=0)) || ((j.indRow == (this.indRow +1)) && (j.indCol == (this.indCol +1)) && (j.gameObject.transform.childCount !=0)) || ((j.indRow == (this.indRow +1)) && (j.indCol == this.indCol)) && (j.gameObject.transform.childCount ==0))) // && (j.gameObject.transform.childCount == 0) 


			{
				if (j.gameObject.transform.childCount == 0)


				{
					validMoves.Add(j);

				}
				else if(this.isWhite != j.PieceInSquare.isWhite)

				{

					validMoves.Add(j);  
				}

				else

				{
					j.GetComponentInParent<Image> ().color = new Color (j.GetComponentInParent<Image> ().color.r, j.GetComponentInParent<Image> ().color.g, j.GetComponentInParent<Image> ().color.b, (float)0.45);


				}
			}
			/*			else if ((((j.indRow == (this.indRow - 1) && (j.indCol == (this.indCol - 1)) && (j.gameObject.transform.childCount !=0) || ((j.indRow == (this.indRow -1)) && (j.indCol == (this.indCol +1)) && (j.gameObject.transform.childCount !=0)) || ((j.indRow == (this.indRow -1)) && (j.indCol == (this.indCol)) && (this. isWhite != j.PieceInSquare.isWhite))

					{
						validMoves.Add(j);
					}*/
			else

			{
				j.GetComponentInParent<Image> ().color = new Color (j.GetComponentInParent<Image> ().color.r, j.GetComponentInParent<Image> ().color.g, j.GetComponentInParent<Image> ().color.b, (float)0.45);

			}

		}



	}



}

