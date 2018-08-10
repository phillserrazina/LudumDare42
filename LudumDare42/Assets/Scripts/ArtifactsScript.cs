﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Artifact", menuName = "Artifact")]
public class ArtifactsScript : ScriptableObject {

	public string artifactName;
	public float moneyValue;
	public int spaceNeeded;
	public CollectionsScript collection;
	public Sprite graphic;
}
