using UnityEngine;
using System.Collections;

public class NetworkManager : MonoBehaviour {
	private const string roomName = "RoomName";
	private RoomInfo[] roomsList;
	public GameObject playerPrefab;

	// Use this for initialization
	void Start () {
		PhotonNetwork.ConnectUsingSettings("0.1");
	}

	// Update is called once per frame
	void Update () {

	}

	void OnReceivedRoomListUpdate()
	{
		roomsList = PhotonNetwork.GetRoomList();
	}
	void OnJoinedRoom()
	{
			float x = Random.Range(-10,10);
			float z = Random.Range(-10,10);
		Vector3 pos = new Vector3 (x, 1.48f, z);
		Debug.Log("Connected to Room");

		GameObject gameObj = (GameObject)PhotonNetwork.Instantiate(playerPrefab.name, pos, Quaternion.Euler(new Vector3(0,-90,0)), 0);
		gameObj.transform.FindChild ("CardboardHead").gameObject.SetActive (true);
		gameObj.transform.FindChild ("EventSystem").gameObject.SetActive (true);
		//Transform t = obj.GetComponentInChildren<CardboardHead> ().transform;
		//		print ("t is" + t.position);
		//		t.Translate (Vector3.up * 4);
		//		print ("after is" + t.position);
		//



	}	
	void OnGUI()
	{
		if (!PhotonNetwork.connected)
		{
			GUILayout.Label(PhotonNetwork.connectionStateDetailed.ToString());
		}

		else if (PhotonNetwork.room == null)
		{				


			// Create Room
			if (PhotonNetwork.countOfRooms==0) {
				PhotonNetwork.CreateRoom (roomName, new RoomOptions () { maxPlayers = 10 }, TypedLobby.Default);

			}


			// Join Room
			else{
				PhotonNetwork.JoinRoom(roomName);

			}

		}
		print(PhotonNetwork.countOfRooms);
	}

}
