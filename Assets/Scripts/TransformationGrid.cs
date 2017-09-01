using UnityEngine;

public class TransformationGrid : MonoBehaviour {
	
	public Transform Prefab;
	public int GridResolution = 10;

	private Transform[] _grid;

	private void Awake () 
	{
		_grid = new Transform[GridResolution * GridResolution * GridResolution];
		for (int i = 0, z = 0; z < GridResolution; z++) {
			for (int y = 0; y < GridResolution; y++) {
				for (int x = 0; x < GridResolution; x++, i++) {
					_grid[i] = CreateGridPoint(x, y, z);
				}
			}
		}
	}
	
	private Transform CreateGridPoint (int x, int y, int z) {
		Transform point = Instantiate(Prefab, transform);
		point.localPosition = GetCoordinates(x, y, z);
		point.GetComponent<MeshRenderer>().material.color = new Color(
			(float)x / GridResolution,
			(float)y / GridResolution,
			(float)z / GridResolution
		);
		return point;
	}
	
	private Vector3 GetCoordinates (int x, int y, int z) {
		return new Vector3(
			x - (GridResolution - 1) * 0.5f,
			y - (GridResolution - 1) * 0.5f,
			z - (GridResolution - 1) * 0.5f
		);
	}
}
