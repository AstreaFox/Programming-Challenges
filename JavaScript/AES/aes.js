document.getElementById("encrypt_button").onclick = e =>
{
	const key = document.getElementById("key_box").value;
	const message = document.getElementById("input_box").value;

	const keyHash = CryptoJS.SHA256(key);
	const ivRaw = CryptoJS.lib.WordArray.random(128/8);
	const plaintextRaw = CryptoJS.enc.Utf8.parse(message);

	const encrypted = CryptoJS.AES.encrypt(plaintextRaw, keyHash, { iv: ivRaw });

	document.getElementById("output_box").value =
		encrypted.iv.toString(CryptoJS.enc.Hex) + ":" +
		encrypted.ciphertext.toString(CryptoJS.enc.Hex);
};

document.getElementById("decrypt_button").onclick = e =>
{
	const key = document.getElementById("key_box").value;
	const encrypted = document.getElementById("input_box").value;
	const iv = encrypted.split(":")[0];
	const ciphertext = encrypted.split(":")[1];

	const keyHash = CryptoJS.SHA256(key);
	const ivRaw = CryptoJS.enc.Hex.parse(iv);
	const ciphertextRaw = CryptoJS.enc.Hex.parse(ciphertext);
	
	const decrypted = CryptoJS.AES.decrypt(
		{ ciphertext: ciphertextRaw }, keyHash, { iv: ivRaw });

	document.getElementById("output_box").value =
		CryptoJS.enc.Utf8.stringify(decrypted);
};
