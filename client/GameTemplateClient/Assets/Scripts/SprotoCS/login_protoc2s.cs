// Generated by sprotodump. DO NOT EDIT!
// source: login_protoc2s.sproto

using System;
using Sproto;
using System.Collections.Generic;

namespace SprotoType { 
	public class auth {
	
		public class request : SprotoTypeBase {
			private static int max_field_count = 2;
			
			
			private string _challenge; // tag 0
			public string challenge {
				get { return _challenge; }
				set { base.has_field.set_field (0, true); _challenge = value; }
			}
			public bool HasChallenge {
				get { return base.has_field.has_field (0); }
			}

			private string _password; // tag 1
			public string password {
				get { return _password; }
				set { base.has_field.set_field (1, true); _password = value; }
			}
			public bool HasPassword {
				get { return base.has_field.has_field (1); }
			}

			public request () : base(max_field_count) {}

			public request (byte[] buffer) : base(max_field_count, buffer) {
				this.decode ();
			}

			protected override void decode () {
				int tag = -1;
				while (-1 != (tag = base.deserialize.read_tag ())) {
					switch (tag) {
					case 0:
						this.challenge = base.deserialize.read_string ();
						break;
					case 1:
						this.password = base.deserialize.read_string ();
						break;
					default:
						base.deserialize.read_unknow_data ();
						break;
					}
				}
			}

			public override int encode (SprotoStream stream) {
				base.serialize.open (stream);

				if (base.has_field.has_field (0)) {
					base.serialize.write_string (this.challenge, 0);
				}

				if (base.has_field.has_field (1)) {
					base.serialize.write_string (this.password, 1);
				}

				return base.serialize.close ();
			}
		}


		public class response : SprotoTypeBase {
			private static int max_field_count = 3;
			
			
			private Int64 _session; // tag 0
			public Int64 session {
				get { return _session; }
				set { base.has_field.set_field (0, true); _session = value; }
			}
			public bool HasSession {
				get { return base.has_field.has_field (0); }
			}

			private Int64 _expire; // tag 1
			public Int64 expire {
				get { return _expire; }
				set { base.has_field.set_field (1, true); _expire = value; }
			}
			public bool HasExpire {
				get { return base.has_field.has_field (1); }
			}

			private string _challenge; // tag 2
			public string challenge {
				get { return _challenge; }
				set { base.has_field.set_field (2, true); _challenge = value; }
			}
			public bool HasChallenge {
				get { return base.has_field.has_field (2); }
			}

			public response () : base(max_field_count) {}

			public response (byte[] buffer) : base(max_field_count, buffer) {
				this.decode ();
			}

			protected override void decode () {
				int tag = -1;
				while (-1 != (tag = base.deserialize.read_tag ())) {
					switch (tag) {
					case 0:
						this.session = base.deserialize.read_integer ();
						break;
					case 1:
						this.expire = base.deserialize.read_integer ();
						break;
					case 2:
						this.challenge = base.deserialize.read_string ();
						break;
					default:
						base.deserialize.read_unknow_data ();
						break;
					}
				}
			}

			public override int encode (SprotoStream stream) {
				base.serialize.open (stream);

				if (base.has_field.has_field (0)) {
					base.serialize.write_integer (this.session, 0);
				}

				if (base.has_field.has_field (1)) {
					base.serialize.write_integer (this.expire, 1);
				}

				if (base.has_field.has_field (2)) {
					base.serialize.write_string (this.challenge, 2);
				}

				return base.serialize.close ();
			}
		}


	}


	public class challenge {
	
		public class request : SprotoTypeBase {
			private static int max_field_count = 2;
			
			
			private Int64 _session; // tag 0
			public Int64 session {
				get { return _session; }
				set { base.has_field.set_field (0, true); _session = value; }
			}
			public bool HasSession {
				get { return base.has_field.has_field (0); }
			}

			private string _challenge; // tag 1
			public string challenge {
				get { return _challenge; }
				set { base.has_field.set_field (1, true); _challenge = value; }
			}
			public bool HasChallenge {
				get { return base.has_field.has_field (1); }
			}

			public request () : base(max_field_count) {}

			public request (byte[] buffer) : base(max_field_count, buffer) {
				this.decode ();
			}

			protected override void decode () {
				int tag = -1;
				while (-1 != (tag = base.deserialize.read_tag ())) {
					switch (tag) {
					case 0:
						this.session = base.deserialize.read_integer ();
						break;
					case 1:
						this.challenge = base.deserialize.read_string ();
						break;
					default:
						base.deserialize.read_unknow_data ();
						break;
					}
				}
			}

			public override int encode (SprotoStream stream) {
				base.serialize.open (stream);

				if (base.has_field.has_field (0)) {
					base.serialize.write_integer (this.session, 0);
				}

				if (base.has_field.has_field (1)) {
					base.serialize.write_string (this.challenge, 1);
				}

				return base.serialize.close ();
			}
		}


		public class response : SprotoTypeBase {
			private static int max_field_count = 2;
			
			
			private string _token; // tag 0
			public string token {
				get { return _token; }
				set { base.has_field.set_field (0, true); _token = value; }
			}
			public bool HasToken {
				get { return base.has_field.has_field (0); }
			}

			private string _challenge; // tag 1
			public string challenge {
				get { return _challenge; }
				set { base.has_field.set_field (1, true); _challenge = value; }
			}
			public bool HasChallenge {
				get { return base.has_field.has_field (1); }
			}

			public response () : base(max_field_count) {}

			public response (byte[] buffer) : base(max_field_count, buffer) {
				this.decode ();
			}

			protected override void decode () {
				int tag = -1;
				while (-1 != (tag = base.deserialize.read_tag ())) {
					switch (tag) {
					case 0:
						this.token = base.deserialize.read_string ();
						break;
					case 1:
						this.challenge = base.deserialize.read_string ();
						break;
					default:
						base.deserialize.read_unknow_data ();
						break;
					}
				}
			}

			public override int encode (SprotoStream stream) {
				base.serialize.open (stream);

				if (base.has_field.has_field (0)) {
					base.serialize.write_string (this.token, 0);
				}

				if (base.has_field.has_field (1)) {
					base.serialize.write_string (this.challenge, 1);
				}

				return base.serialize.close ();
			}
		}


	}


	public class handshake {
	
		public class request : SprotoTypeBase {
			private static int max_field_count = 2;
			
			
			private string _name; // tag 0
			public string name {
				get { return _name; }
				set { base.has_field.set_field (0, true); _name = value; }
			}
			public bool HasName {
				get { return base.has_field.has_field (0); }
			}

			private string _client_pub; // tag 1
			public string client_pub {
				get { return _client_pub; }
				set { base.has_field.set_field (1, true); _client_pub = value; }
			}
			public bool HasClient_pub {
				get { return base.has_field.has_field (1); }
			}

			public request () : base(max_field_count) {}

			public request (byte[] buffer) : base(max_field_count, buffer) {
				this.decode ();
			}

			protected override void decode () {
				int tag = -1;
				while (-1 != (tag = base.deserialize.read_tag ())) {
					switch (tag) {
					case 0:
						this.name = base.deserialize.read_string ();
						break;
					case 1:
						this.client_pub = base.deserialize.read_string ();
						break;
					default:
						base.deserialize.read_unknow_data ();
						break;
					}
				}
			}

			public override int encode (SprotoStream stream) {
				base.serialize.open (stream);

				if (base.has_field.has_field (0)) {
					base.serialize.write_string (this.name, 0);
				}

				if (base.has_field.has_field (1)) {
					base.serialize.write_string (this.client_pub, 1);
				}

				return base.serialize.close ();
			}
		}


		public class response : SprotoTypeBase {
			private static int max_field_count = 4;
			
			
			private bool _user_exists; // tag 0
			public bool user_exists {
				get { return _user_exists; }
				set { base.has_field.set_field (0, true); _user_exists = value; }
			}
			public bool HasUser_exists {
				get { return base.has_field.has_field (0); }
			}

			private string _salt; // tag 1
			public string salt {
				get { return _salt; }
				set { base.has_field.set_field (1, true); _salt = value; }
			}
			public bool HasSalt {
				get { return base.has_field.has_field (1); }
			}

			private string _server_pub; // tag 2
			public string server_pub {
				get { return _server_pub; }
				set { base.has_field.set_field (2, true); _server_pub = value; }
			}
			public bool HasServer_pub {
				get { return base.has_field.has_field (2); }
			}

			private string _challenge; // tag 3
			public string challenge {
				get { return _challenge; }
				set { base.has_field.set_field (3, true); _challenge = value; }
			}
			public bool HasChallenge {
				get { return base.has_field.has_field (3); }
			}

			public response () : base(max_field_count) {}

			public response (byte[] buffer) : base(max_field_count, buffer) {
				this.decode ();
			}

			protected override void decode () {
				int tag = -1;
				while (-1 != (tag = base.deserialize.read_tag ())) {
					switch (tag) {
					case 0:
						this.user_exists = base.deserialize.read_boolean ();
						break;
					case 1:
						this.salt = base.deserialize.read_string ();
						break;
					case 2:
						this.server_pub = base.deserialize.read_string ();
						break;
					case 3:
						this.challenge = base.deserialize.read_string ();
						break;
					default:
						base.deserialize.read_unknow_data ();
						break;
					}
				}
			}

			public override int encode (SprotoStream stream) {
				base.serialize.open (stream);

				if (base.has_field.has_field (0)) {
					base.serialize.write_boolean (this.user_exists, 0);
				}

				if (base.has_field.has_field (1)) {
					base.serialize.write_string (this.salt, 1);
				}

				if (base.has_field.has_field (2)) {
					base.serialize.write_string (this.server_pub, 2);
				}

				if (base.has_field.has_field (3)) {
					base.serialize.write_string (this.challenge, 3);
				}

				return base.serialize.close ();
			}
		}


	}


	public class login {
	
		public class request : SprotoTypeBase {
			private static int max_field_count = 2;
			
			
			private Int64 _session; // tag 0
			public Int64 session {
				get { return _session; }
				set { base.has_field.set_field (0, true); _session = value; }
			}
			public bool HasSession {
				get { return base.has_field.has_field (0); }
			}

			private string _token; // tag 1
			public string token {
				get { return _token; }
				set { base.has_field.set_field (1, true); _token = value; }
			}
			public bool HasToken {
				get { return base.has_field.has_field (1); }
			}

			public request () : base(max_field_count) {}

			public request (byte[] buffer) : base(max_field_count, buffer) {
				this.decode ();
			}

			protected override void decode () {
				int tag = -1;
				while (-1 != (tag = base.deserialize.read_tag ())) {
					switch (tag) {
					case 0:
						this.session = base.deserialize.read_integer ();
						break;
					case 1:
						this.token = base.deserialize.read_string ();
						break;
					default:
						base.deserialize.read_unknow_data ();
						break;
					}
				}
			}

			public override int encode (SprotoStream stream) {
				base.serialize.open (stream);

				if (base.has_field.has_field (0)) {
					base.serialize.write_integer (this.session, 0);
				}

				if (base.has_field.has_field (1)) {
					base.serialize.write_string (this.token, 1);
				}

				return base.serialize.close ();
			}
		}


	}


	public class myauth {
	
		public class request : SprotoTypeBase {
			private static int max_field_count = 1;
			
			
			private string _password; // tag 0
			public string password {
				get { return _password; }
				set { base.has_field.set_field (0, true); _password = value; }
			}
			public bool HasPassword {
				get { return base.has_field.has_field (0); }
			}

			public request () : base(max_field_count) {}

			public request (byte[] buffer) : base(max_field_count, buffer) {
				this.decode ();
			}

			protected override void decode () {
				int tag = -1;
				while (-1 != (tag = base.deserialize.read_tag ())) {
					switch (tag) {
					case 0:
						this.password = base.deserialize.read_string ();
						break;
					default:
						base.deserialize.read_unknow_data ();
						break;
					}
				}
			}

			public override int encode (SprotoStream stream) {
				base.serialize.open (stream);

				if (base.has_field.has_field (0)) {
					base.serialize.write_string (this.password, 0);
				}

				return base.serialize.close ();
			}
		}


		public class response : SprotoTypeBase {
			private static int max_field_count = 3;
			
			
			private Int64 _session; // tag 0
			public Int64 session {
				get { return _session; }
				set { base.has_field.set_field (0, true); _session = value; }
			}
			public bool HasSession {
				get { return base.has_field.has_field (0); }
			}

			private Int64 _expire; // tag 1
			public Int64 expire {
				get { return _expire; }
				set { base.has_field.set_field (1, true); _expire = value; }
			}
			public bool HasExpire {
				get { return base.has_field.has_field (1); }
			}

			private string _token; // tag 2
			public string token {
				get { return _token; }
				set { base.has_field.set_field (2, true); _token = value; }
			}
			public bool HasToken {
				get { return base.has_field.has_field (2); }
			}

			public response () : base(max_field_count) {}

			public response (byte[] buffer) : base(max_field_count, buffer) {
				this.decode ();
			}

			protected override void decode () {
				int tag = -1;
				while (-1 != (tag = base.deserialize.read_tag ())) {
					switch (tag) {
					case 0:
						this.session = base.deserialize.read_integer ();
						break;
					case 1:
						this.expire = base.deserialize.read_integer ();
						break;
					case 2:
						this.token = base.deserialize.read_string ();
						break;
					default:
						base.deserialize.read_unknow_data ();
						break;
					}
				}
			}

			public override int encode (SprotoStream stream) {
				base.serialize.open (stream);

				if (base.has_field.has_field (0)) {
					base.serialize.write_integer (this.session, 0);
				}

				if (base.has_field.has_field (1)) {
					base.serialize.write_integer (this.expire, 1);
				}

				if (base.has_field.has_field (2)) {
					base.serialize.write_string (this.token, 2);
				}

				return base.serialize.close ();
			}
		}


	}


}

