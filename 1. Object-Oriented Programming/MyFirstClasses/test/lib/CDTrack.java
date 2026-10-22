package lib;

public class CDTrack {
	// Fields
	private String title = "";
	private String artist = "";
	private int duration = 0;
	
	// Constructors
	public CDTrack() {
		this.title = "";
		this.artist = "";
		this.duration = 0;
	}
	
	public CDTrack(String title, String artist, int duration) {
		this.title = title;
		this.artist = artist;
		this.duration = duration < 0 ? 0 : duration;
	}
	
	// Methods
	public void setTitle(String title) {
		this.title = title;
	}
	
	public void setArtist(String artist) {
		this.artist = artist;
	}
	
	public void setDuration(int duration) {
		this.duration = duration < 0 ? 0 : duration;
	}
	
	public String getTitle() {
		return this.title;
	}
	
	public String getArtist() {
		return this.artist;
	}
	
	public int getDuration() {
		return this.duration;
	}
	
	@Override
	public String toString() {
		return "CDTrack:[title=" + title + ", artist=" + artist + ", duration=" + duration + "]";
	}
}
