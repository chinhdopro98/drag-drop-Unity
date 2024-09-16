using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardCreator : MonoBehaviour
{
    public Vector3 startPosition = Vector3.zero;
    public GameObject tilePrefab; // Prefab của ô bàn cờ (sử dụng Cube hoặc Quad)
    public int rows = 3;          // Số hàng
    public int columns = 4;       // Số cột
    public float tileSize = 1.0f; // Kích thước của mỗi ô

    void Start()
    {
        CreateBoard();
    }

    void CreateBoard()
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                // Tính toán vị trí của mỗi ô
                Vector3 tilePosition = new Vector3(j * tileSize, 0, i * tileSize);
                // Tạo một ô bàn cờ mới
                Instantiate(tilePrefab, tilePosition, Quaternion.identity, transform);
            }
        }
    }
}
